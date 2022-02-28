using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcServiceTest;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
          
            
            /*var chanel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(chanel);
            
            var input = new HelloRequest{Name = "Dima"};
            
            var result = await client.SayHelloAsync(input);

            Console.WriteLine(result.Message);*/

            var chanel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Customer.CustomerClient(chanel);

            Console.WriteLine("Enter user id");
            var value = int.Parse(Console.ReadLine()!);
            
            var clientRequest = new CustomerLookupModel { UserId = value };

            var customer = await client.GetCustomerInfoAsync(clientRequest);
            
            Console.WriteLine($"{customer.FirstName} {customer.LastName}");
            
            Console.ReadLine();
        }
    }
}