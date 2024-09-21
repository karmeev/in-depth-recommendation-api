using InDepthRecommendation.Models;

namespace InDepthRecommendation.Data.Contracts.Repositories;

public interface IUserActionRepository: IRepository
{
    Task InsertAction(UserAction action);
    Task<UserAction> GetActionById(string id);
}