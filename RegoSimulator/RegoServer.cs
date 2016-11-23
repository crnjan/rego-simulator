using System;
using System.Net;
using System.Linq;
using System.Net.Sockets;
using System.Collections.Generic;

namespace RegoSimulator
{
    class RegoServer
    {
        private readonly RegoMapper regoMapper;
        private readonly LinkedList<TcpClient> clients = new LinkedList<TcpClient>();
        private TcpListener listener;

        public bool IsRunning { get { return listener != null; } }


        public RegoServer(RegoMapper regoMapper)
        {
            this.regoMapper = regoMapper;
        }

        public void Start(int port)
        {
            if (listener != null)
                return;

            listener = new TcpListener(IPAddress.Any, port);
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

        private async void ProcessClientRequests(TcpClient client)
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
                case 0x02:
                    return ReadFromSystemRegister(address, data);

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
            var value = regoMapper.ValueForAddress(address);
            if (value.HasValue == false)
                throw new InvalidOperationException();

            var dataBytes = ConvertFromShort((Int16)(value.Value * 10));
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
    }
}
