using System;
using System.Threading.Tasks;

namespace RegoSimulator.Comm
{
    interface IServer
    {
        void Start();
        void Stop();

        Task<IClient> AcceptTcpClientAsync();
    }
}
