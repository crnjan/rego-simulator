using System;
using System.Net;
using System.Linq;
using System.Collections.Generic;

namespace RegoSimulator
{
    class RegoServer
    {
        private readonly RegoMapper regoMapper;
        private readonly IList<ErrorLine> errorList = new List<ErrorLine>();
        private readonly LinkedList<Comm.IClient> clients = new LinkedList<Comm.IClient>();
        private Comm.IServer listener;
        private int? errorIndex;

        public bool IsRunning { get { return listener != null; } }

        public IList<ErrorLine> ErrorList { get { return errorList; } }
        public bool FrontPanelLed1_Power { get; set; }
        public bool FrontPanelLed2_Pump { get; set; }
        public bool FrontPanelLed3_AdditionalHeat { get; set; }
        public bool FrontPanelLed4_WaterHeat { get; set; }
        public bool FrontPanelLed5_Alarm { get; set; }


        public RegoServer(RegoMapper regoMapper)
        {
            this.regoMapper = regoMapper;
        }

        public void Start(Comm.IServer listener)
        {
            if (this.listener != null)
                throw new InvalidOperationException();

            this.listener = listener;
            listener.Start();

            ProcessIncommingConnections();
        }

        private async void ProcessIncommingConnections()
        {
            try
            {
                while (true)
                {
                    var client = await listener.AcceptTcpClientAsync();
                    ProcessClientRequests(client);
                }
            }
            catch (Exception e)
            {

            }
        }

        private async void ProcessClientRequests(Comm.IClient client)
        {
            const int commandLength = 9;

            var node = clients.AddLast(client);

            try
            {
                var buffer = new byte[commandLength];
                using (var stream = client.GetStream())
                {
                    while (true)
                    {
                        var len = await stream.ReadAsync(buffer, 0, commandLength);
                        if (len != commandLength)
                            throw new InvalidOperationException();

                        if (buffer[0] != 0x81)
                            throw new InvalidOperationException();

                        await System.Threading.Tasks.Task.Delay(40);

                        var response = ProcessCommand(buffer);
                        await stream.WriteAsync(response, 0, response.Length);
                    }
                }
            }
            catch (Exception e)
            {
                client.Close();
            }

            try { clients.Remove(node); } catch { }
        }

        public void Stop()
        {
            if (listener == null)
                return;

            listener.Stop();
            listener = null;

            foreach (var client in clients)
                client.Close();

            clients.Clear();
        }

        private byte[] ProcessCommand(byte[] buffer)
        {
            int crc = buffer.Skip(2).Take(6).Aggregate((a, b) => (byte)(a ^ b));
            if (crc != buffer[8])
                throw new InvalidOperationException();

            int command = buffer[1];
            int address = ConvertToShort(buffer, 2);
            int data = ConvertToShort(buffer, 5);

            switch (command)
            {
                case 0x00:
                    return ReadFromFrontPanel(address, data);

                case 0x02:
                    return ReadFromSystemRegister(address, data);

//                case 0x20:
//                    return ReadFromDisplay(address, data);

                case 0x40:
                    return ReadLastErrorLine(address, data);

                case 0x41:
                    return ReadNextErrorLine(address, data);

                case 0x7F:
                    return ReadRegoVersion(address, data);

                default:
                    throw new InvalidOperationException();
            }
        }

        private byte[] ReadRegoVersion(int address, int data)
        {
            if (address != 0 || data != 0)
                throw new InvalidOperationException();

            return new byte[] { 0x01, 0x00, 0x04, 0x58, 0x5c };
        }

        private byte[] ReadFromSystemRegister(int address, int data)
        {
            if (data != 0)
                throw new InvalidOperationException();

            var value = regoMapper.ValueForAddress(address);
            if (value.HasValue == false)
            {
                //throw new InvalidOperationException();
                return CreateShortResponse((short)address);
            }

            return CreateShortResponse((Int16)(value.Value * 10));
        }

        private byte[] CreateShortResponse(short data)
        {
            var dataBytes = ConvertFromShort(data);
            return new byte[] { 0x01, dataBytes[0], dataBytes[1], dataBytes[2], dataBytes.Aggregate((a, b) => (byte)(a ^ b)) };
        }

        private static int ConvertToShort(byte[] buffer, int offset)
        {
            System.Diagnostics.Debug.Assert(BitConverter.IsLittleEndian);
            return (buffer[offset] << 14) | (buffer[offset + 1] << 7) | buffer[offset + 2];
        }

        private static byte[] ConvertFromShort(Int16 value)
        {
            System.Diagnostics.Debug.Assert(BitConverter.IsLittleEndian);
            return new byte[] { (byte)((value & 0xC000) >> 14), (byte)((value & 0x3F80) >> 7), (byte)(value & 0x007F) };
        }

        /*private static byte[] CreateStringMessage(string text)
        {
            var textBytes = System.Text.Encoding.ASCII.GetBytes(text ?? "");
            var buffer = new byte[StringMessageLength * 2 + 2];

            buffer[0] = 0x01;

            for (int i = 0; i < StringMessageLength; ++i)
            {
                int ascii = i < textBytes.Length ? textBytes[i] : 0x20;
                int index = 1 + 2 * i;

                buffer[index] = (byte)((ascii & 0xf0) >> 4);
                buffer[index + 1] = (byte)(ascii & 0x0f);
            }

            var crc = buffer.Skip(1).Take(StringMessageLength * 2).Aggregate((a, b) => (byte)(a ^ b));
            buffer[buffer.Length - 1] = crc;

            return buffer;
        } */

        private static void WriteStringMessage(string text, byte[] buffer, int offset)
        {
            var textBytes = System.Text.Encoding.ASCII.GetBytes(text);
            for (int i = 0; i < textBytes.Length; ++i)
            {
                int ascii = textBytes[i];
                int index = offset + 2 * i;

                buffer[index] = (byte)((ascii & 0xf0) >> 4);
                buffer[index + 1] = (byte)(ascii & 0x0f);
            }
        }

        /*private byte[] ReadFromDisplay(int address, int data)
        {
            if (data != 0)
                throw new InvalidOperationException();

            return CreateStringMessage("Hello from Rego600 Simulator.");
        }*/

        private static byte[] CreateResponseFromErrorLine(ErrorLine? error)
        {
            var payload = new byte[42];

            payload[0] = 0x01;

            if (error.HasValue)
            {
                payload[1] = error.Value.Error;

                var timestampString = error.Value.Timestamp.ToString("yyMMdd HH:mm:ss");
                WriteStringMessage(timestampString, payload, 2);
            }
            else
            {
                payload[1] = 255;   // No error
            }

            var crc = payload.Skip(1).Take(payload.Length - 2).Aggregate((a, b) => (byte)(a ^ b));
            payload[payload.Length - 1] = crc;

            return payload;
        }

        private byte[] ReadLastErrorLine(int address, int data)
        {
            if (data != 0 || address != 0)
                throw new InvalidOperationException();

            var line = errorList.Count == 0 ? (ErrorLine ? )null : errorList.Last();
            return CreateResponseFromErrorLine(line);
        }

        private byte[] ReadNextErrorLine(int address, int data)
        {
            if (data != 0 || address != 0)
                throw new InvalidOperationException();

            if (errorIndex.HasValue == false)
                throw new InvalidOperationException();

            return null;
        }

        private byte[] ReadFromFrontPanel(int address, int data)
        {
            if (data != 0)
                throw new InvalidOperationException();

            bool value;
            switch (address)
            {
                case 0x0012: value = FrontPanelLed1_Power; break;
                case 0x0013: value = FrontPanelLed2_Pump; break;
                case 0x0014: value = FrontPanelLed3_AdditionalHeat; break;
                case 0x0015: value = FrontPanelLed4_WaterHeat; break;
                case 0x0016: value = FrontPanelLed5_Alarm; break;
                default: throw new InvalidOperationException();
            }

            return CreateShortResponse((short)(value ? 1 : 0));
        }
    }
}
