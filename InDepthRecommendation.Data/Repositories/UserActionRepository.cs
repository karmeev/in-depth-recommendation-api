using InDepthRecommendation.Data.ClassMaps;
using InDepthRecommendation.Data.Contracts;
using InDepthRecommendation.Data.Contracts.Repositories;
using InDepthRecommendation.Models;

namespace InDepthRecommendation.Data.Repositories;

public class UserActionRepository(IDbContext dbContext) : IUserActionRepository
{
    public async Task InsertAction(UserAction action)
    {
        action.Id = Guid.NewGuid().ToString();
        var collection = await dbContext.WriteAsync<UserAction>();
        await collection.InsertOneAsync(action);
    }

    public async Task<UserAction> GetActionById(string id)
    {
        var collection = await dbContext.ReadAsync();
        var value = collection.StringGet(id);
        var result = value.MapToUserAction();
        return result;
    }
}