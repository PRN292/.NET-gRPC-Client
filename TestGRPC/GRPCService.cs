using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Net.Client;
using GrpcImage;

namespace TestGRPC
{
    class GRPCService
    {
        public string Address{ get; set; }
        private GrpcChannel grpcChannel;
        private ProcessImage.ProcessImageClient client;

        public GRPCService(string Address)
        {
            AppContext.SetSwitch(
    "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            this.Address = Address;
            grpcChannel = GrpcChannel.ForAddress(Address);
            client = new ProcessImage.ProcessImageClient(grpcChannel);
        }

        public async Task GetProcessedFrame()
        {
            using (var call = client.ProcessImage(new ProcessImageRequest { Id = "1" }))
            {
                var responseStream = call.ResponseStream;
                int i = 0;
                while (await responseStream.MoveNext())
                {
                    Console.WriteLine(i++);
                    ProcessImageReply reply = responseStream.Current;
                    Console.WriteLine(reply);
                } 
            }
        }

        public int DeleteEncoding(string image_name)
        {
            DeleteEncodingRequest request = new DeleteEncodingRequest { ImageName = image_name };
            DeleteEncodingReply reply = client.DeleteEncoding(request);
            return reply.Count;
        }

        public CreateEncodingReply CreateEncoding(string user_email, string image_b64_string)
        {
            CreateEncodingRequest request = new CreateEncodingRequest
            {
                Image = image_b64_string,
                UserEmail = user_email
            };
            CreateEncodingReply reply = client.CreateEncoding(request);
            return reply;
        }
    }
}
