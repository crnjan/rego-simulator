using System;
using System.IO;

namespace RegoSimulator.Comm
{
    interface IClient
    {
        Stream GetStream();
        void Close();
    }
}
