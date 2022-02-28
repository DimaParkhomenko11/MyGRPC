using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GrpcServiceTest.Services
{
    public class CustomersService : Customer.CustomerBase
    {
        private readonly ILogger<GreeterService> _logger;
        
        public CustomersService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<CustomerModel> GetCustomerInfo(CustomerLookupModel request, ServerCallContext context)
        {
            var output = new CustomerModel();
            if (request.UserId == 1)
            {
                output.FirstName = "Dima";
                output.LastName = "Parkhomenko";
            }
            else if (request.UserId == 1)
            {
                output.FirstName = "John";
                output.LastName = "Kekolynsky";
            }
            
            return Task.FromResult(output);
        }
    }
}