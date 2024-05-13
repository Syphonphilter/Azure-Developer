using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class HTTPTriggerWithRouteParameters
    {
        private readonly ILogger<HTTPTriggerWithRouteParameters> _logger;

        public HTTPTriggerWithRouteParameters(ILogger<HTTPTriggerWithRouteParameters> logger)
        {
            _logger = logger;
        }

        [Function("HTTPTriggerWithRouteParameters")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
