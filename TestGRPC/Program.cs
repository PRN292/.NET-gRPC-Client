using Grpc.Net.Client;
using System;
using System.Threading.Tasks;
using GrpcImage;
using System.Runtime.InteropServices;
using System.Net.Http;
using Grpc.Core;

namespace TestGRPC
{

    class Program
    {
        static public async Task Main(string[] args)
        {
            string serverAddr = "http://localhost:50051";
            AppContext.SetSwitch(
    "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);

            using var channel = GrpcChannel.ForAddress(serverAddr);
            var client = new GrpcImage.ProcessImage.ProcessImageClient(channel);
            using (var call = client.ProcessImage(new ProcessImageRequest { Id = "1" }))
            {
                var responseStream = call.ResponseStream;
                int i = 0;
                while (await responseStream.MoveNext())
                {
                    Console.WriteLine(i++);
                    ProcessImageReply reply = responseStream.Current;
                    Console.WriteLine(reply.Result);
                }
            }
           /* DeleteEncodingReply reply = client.DeleteEncoding(
                    new DeleteEncodingRequest { ImageName = "7bf140b7-bf44-4528-b445-c257535d51a2.png" }
                );
            Console.WriteLine("Count: " + reply.Count);*/
        }
    }
}
