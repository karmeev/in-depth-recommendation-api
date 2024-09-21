using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace InDepthRecommendation.Rest.Api.Controllers;

public abstract class ApiController(ILogger logger) : ControllerBase
{
    private ILogger Logger { get; set; } = logger;

    //transport to service filter
    protected void StartControllerExecution(string message)
    {
        Logger.Log(LogLevel.Information, $"Start; {message}");
    }
    
    protected IActionResult Complete(string message)
    {
        Logger.Log(LogLevel.Information, $"Complete; {message}");
        return Ok();
    }
    
    protected IActionResult Complete<T>(string message, T response)
    {
        Logger.Log(LogLevel.Information, $"Complete; {message}");
        return Ok(response);
    }
    
    //transport to global exception handler
    protected void FailControllerExecution(string message)
    {
        Logger.Log(LogLevel.Error, $"Fail; {message}");
    }
}