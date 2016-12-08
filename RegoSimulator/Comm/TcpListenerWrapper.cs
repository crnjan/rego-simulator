using System;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace RegoSimulator.Comm
{
    class TcpListenerWrapper : IServer
    {
        private readonly TcpListener listener;


        public TcpListenerWrapper(TcpListener listener)
        {
            this.listener = listener;
        }

        public async Task<IClient> AcceptTcpClientAsync()
        {
            return new TcpClientWrapper(await listener.AcceptTcpClientAsync());
        }

        public void Start()
        {
            listener.Start();
        }

        public void Stop()
        {
            listener.Stop();
        }
    }
}
