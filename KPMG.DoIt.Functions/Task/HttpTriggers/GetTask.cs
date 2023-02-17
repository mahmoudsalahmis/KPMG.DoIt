using KPMG.DoIt.Application.Task.Query.GetTaskById;
using MediatR;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Net;

namespace KPMG.DoIt.Functions.Task.HttpTriggers
{
    public class GetTask
    {
        private readonly ILogger _logger;
        private readonly ISender _sender;

        public GetTask(ILoggerFactory loggerFactory, ISender sender)
        {
            _logger = loggerFactory.CreateLogger<GetTask>();
            _sender = sender;
        }

        [Function("ToDo")]
        public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
        {
            //_logger.LogInformation("C# HTTP trigger function processed a request.");

            //var response = req.CreateResponse(HttpStatusCode.OK);
            //response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            //response.WriteString("Welcome to Azure Functions!");

            var result = await _sender.Send(new GetTaskByIdQuery("123"));

            var response = req.CreateResponse(HttpStatusCode.OK);
            await response.WriteAsJsonAsync(result);
            return response;
        }
    }
}
