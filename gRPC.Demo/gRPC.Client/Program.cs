using System;
using System.Threading.Tasks;
using gRPC.Server;
using Grpc.Net.Client;

namespace gRPC.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var input = new HelloRequest { Name = "Pedro" };
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);

            var reply = await client.SayHelloAsync(input);

            Console.WriteLine(reply.Message);

            Console.ReadLine();
        }
    }
}
