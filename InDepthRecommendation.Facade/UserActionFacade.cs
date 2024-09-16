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
            Action = "click"
        };

        var repository = RepositoryManager.GetRepository<IUserActionRepository>();
        await repository.InsertAction(model);
    }
    
    public async Task GetAction()
    {
        //test value
        var id = "1234-567-2";

        var repository = RepositoryManager.GetRepository<IUserActionRepository>();
        await repository.GetActionById(id);
    }
}