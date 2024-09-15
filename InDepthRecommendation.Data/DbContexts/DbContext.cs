using InDepthRecommendation.Data.Contracts;
using MongoDB.Driver;

namespace InDepthRecommendation.Data.DbContexts;

public class DbContext: IDbContext
{
    private readonly MongoDbContext _mongoDbContext;

    public DbContext(MongoDbContext mongoDbContext)
    {
        _mongoDbContext = mongoDbContext;
    }

    public async Task<IMongoCollection<T>> WriteAsync<T>()
    {
        await _mongoDbContext.StartSession();
        return _mongoDbContext.GetCollection<T>();
    }
}