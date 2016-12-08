using System;
using System.IO;
using System.Net.Sockets;

namespace RegoSimulator.Comm
{
    class TcpClientWrapper : IClient
    {
        private readonly TcpClient client;


        public TcpClientWrapper(TcpClient client)
        {
            this.client = client;
        }

        public void Close()
        {
            client.Close();
        }

        public Stream GetStream()
        {
            return client.GetStream();
        }
    }
}
