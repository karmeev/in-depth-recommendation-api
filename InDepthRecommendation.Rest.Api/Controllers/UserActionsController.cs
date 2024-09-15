using InDepthRecommendation.Facade.Contracts;
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
    public async Task<IActionResult> AddAction()
    {
        StartControllerExecution("Add user action");

        await _userActionFacade.AddAction(new AddUserActionRequest());
        
        return CompleteControllerExecution("Add user action");
    }
}