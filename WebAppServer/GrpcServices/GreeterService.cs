using Grpc.Core;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebAppServer.GrpcEndPoint;

namespace WebAppServer.GrpcServices
{
    public class GreeterService : Greeter.GreeterBase
    {
        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply() { Message = $"Hello {request.Name }" });
        }
    }
}
