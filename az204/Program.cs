using System;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace az204
{
    class Program
    {
        private const string _clientId = "5fa74106-4d6e-450f-bd2e-c7f17a39a1d8"; 

        private const string _tenantId = "a74a5755-0fd5-42b5-b704-f3b5a3323678";
        
        public static async Task Main(string[] args)
        {
            var app = PublicClientApplicationBuilder
            .Create(_clientId)
            .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
            .WithRedirectUri ("http://localhost")
            .Build();
            string[] scopes = { "user.read" };
            AuthenticationResult result = await app.AcquireTokenInteractive(scopes).ExecuteAsync();
            Console.WriteLine($"Token:\t{result.AccessToken}");
        }
        
    }
}
