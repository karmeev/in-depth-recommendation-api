using InDepthRecommendation.Data.Contracts.Repositories;
using InDepthRecommendation.Data.Repositories;
using InDepthRecommendation.Facade.Contracts;
using InDepthRecommendation.Models;
using InDepthRecommendation.Rest.Api.Contracts.Requests;

namespace InDepthRecommendation.Facade;

public class UserActionFacade(RepositoryManager repositoryManager) 
    : AbstractFacade(repositoryManager), IUserActionFacade
{
    public async Task AddAction(AddUserActionRequest request)
    {
        var model = new UserAction
        {
            Action = request.ActionName
        };

        var repository = RepositoryManager.GetRepository<IUserActionRepository>();
        await repository.InsertAction(model);
    }
    
    public async Task<UserAction> GetAction(string id)
    {
        var repository = RepositoryManager.GetRepository<IUserActionRepository>();
        var result = await repository.GetActionById(id);
        return result;
    }
}