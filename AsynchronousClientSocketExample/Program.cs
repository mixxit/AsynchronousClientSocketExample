using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

namespace AsynchronousClientSocketExample
{
    class Program
    {
        public static int Main(String[] args)
        {
            AsynchronousClient.StartClient();
            return 0;
        }
    }
}
