using InDepthRecommendation.Data.Contracts;
using InDepthRecommendation.Models.Contracts;
using MongoDB.Driver;

namespace InDepthRecommendation.Data.DbContexts;

public class DbContext(MongoDbContext mongoDbContext) : IDbContext
{
    public async Task<IMongoCollection<TEntity>> WriteAsync<TEntity>()
    where TEntity: IEntity
    {
        await mongoDbContext.StartSession();
        return mongoDbContext.GetCollection<TEntity>();
    }
}