using InDepthRecommendation.Data.Contracts;
using InDepthRecommendation.Models.Contracts;
using MongoDB.Driver;
using StackExchange.Redis;

namespace InDepthRecommendation.Data.DbContexts;

public class DbContext(MongoDbContext mongoDbContext, RedisDbContext redisDbContext) : IDbContext
{
    public async Task<IMongoCollection<TEntity>> WriteAsync<TEntity>() 
        where TEntity: IEntity
    {
        await mongoDbContext.StartSession();
        return mongoDbContext.GetCollection<TEntity>();
    }

    public async Task<IDatabase> ReadAsync()
    {
        await redisDbContext.StartSession();
        return redisDbContext.GetCollection();
    }
}