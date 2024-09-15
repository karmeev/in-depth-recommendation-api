using InDepthRecommendation.Facade.Contracts;
using InDepthRecommendation.Rest.Api.Contracts.Requests;

namespace InDepthRecommendation.Facade;

public class UserActionFacade: IUserActionFacade
{
    public async Task AddAction(AddUserActionRequest request)
    {
        await Task.CompletedTask;
    }
}