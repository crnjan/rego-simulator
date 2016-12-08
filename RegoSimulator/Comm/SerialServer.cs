using System;
using System.IO.Ports;
using System.Threading.Tasks;

namespace RegoSimulator.Comm
{
    class SerialServer : IServer
    {
        private bool isDone = false;

        public async Task<IClient> AcceptTcpClientAsync()
        {
            if (isDone)
                await Task.Delay(TimeSpan.FromHours(10));

            isDone = true;
            var serialPort = new SerialPort("COM6", 19200, Parity.None, 8, StopBits.One);
            serialPort.Open();

            return new SerialClient(serialPort);
        }

        public void Start()
        {
        }

        public void Stop()
        {
        }
    }
}
