using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Channel("127.0.0.1", ChannelCredentials.Insecure);
            var s = new HelloWorldService.HelloWorldServiceClient(c);
        }
    }
}
