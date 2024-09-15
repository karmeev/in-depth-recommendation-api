using InDepthRecommendation.Data.Contracts;
using InDepthRecommendation.Data.Contracts.Repositories;
using InDepthRecommendation.Models;

namespace InDepthRecommendation.Data.Repositories;

public class UserActionRepository: IUserActionRepository
{
    private readonly IDbContext _dbContext;

    public UserActionRepository(IDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task InsertAction(UserAction action)
    {
        var collection = await _dbContext.WriteAsync<UserAction>();
        await collection.InsertOneAsync(action);
    }
}