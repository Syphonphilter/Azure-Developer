using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class AzureHTTPTTriggerFunction
    {
        private readonly ILogger<AzureHTTPTTriggerFunction> _logger;

        public AzureHTTPTTriggerFunction(ILogger<AzureHTTPTTriggerFunction> logger)
        {
            _logger = logger;
        }

        [Function("AzureHTTPTTriggerFunction")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {

            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult($"Welcome to Azure Functions!, {req.Query["name"]}");
        }
    }
}
