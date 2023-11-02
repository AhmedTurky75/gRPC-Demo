using Grpc.Core;
using gRPC_Server.Protos;

namespace gRPC_Server.Services
{
	public class ForcastSevice : Forcast.ForcastBase
	{
		public ForcastSevice()
		{
		}

		public override Task<GetNameResponse> getName(GetNameRequest request, ServerCallContext context)
		{
			return Task.FromResult(new GetNameResponse() { Weather = "Sunny" });
		}
	}
}
