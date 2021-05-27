using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Client.GrpcEndPoint;

namespace WebAppClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GrpcCallController : ControllerBase
    {
        private readonly Greeter.GreeterClient _client;
        public GrpcCallController(Greeter.GreeterClient client)
        {
            _client = client;
        }

        [HttpGet]
        public async Task<string> Get(string name)
        {
            var reply = await _client.SayHelloAsync(
                              new HelloRequest { Name = name });

            return reply.Message;
        }
    }
}
