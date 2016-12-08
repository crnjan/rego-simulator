using System;
using System.IO;
using System.IO.Ports;

namespace RegoSimulator.Comm
{
    class SerialClient : IClient
    {
        private readonly SerialPort serialPort;


        public SerialClient(SerialPort serialPort)
        {
            this.serialPort = serialPort;
        }

        public void Close()
        {
            serialPort.Dispose();
        }

        public Stream GetStream()
        {
            return serialPort.BaseStream;
        }
    }
}
