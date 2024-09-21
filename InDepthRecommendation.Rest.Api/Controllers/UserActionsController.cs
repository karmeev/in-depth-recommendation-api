using InDepthRecommendation.Facade.Contracts;
using InDepthRecommendation.Models;
using InDepthRecommendation.Rest.Api.Contracts.Requests;
using Microsoft.AspNetCore.Mvc;

namespace InDepthRecommendation.Rest.Api.Controllers;

[ApiController]
[Route("actions")]
public class UserActionsController: ApiController
{
    private readonly IUserActionFacade _userActionFacade;
    
    public UserActionsController(ILogger<UserActionsController> logger, 
        IUserActionFacade userActionFacade) : base(logger)
    {
        _userActionFacade = userActionFacade;
    }
    
    [HttpPost("insert")]
    public async Task<IActionResult> AddAction([FromBody] AddUserActionRequest request)
    {
        StartControllerExecution("Add user action");

        await _userActionFacade.AddAction(request);
        
        return Complete("Add user action");
    }
    
    [HttpGet("get")]
    public async Task<IActionResult> GetAction([FromQuery] string id)
    {
        StartControllerExecution("Get user action");

        var result = await _userActionFacade.GetAction(id);
        
        return Complete("Get user action", result);
    }
}