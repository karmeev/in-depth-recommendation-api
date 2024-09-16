using InDepthRecommendation.Models.Contracts;
using MongoDB.Driver;
using StackExchange.Redis;

namespace InDepthRecommendation.Data.Contracts;

public interface IDbContext
{
    Task<IMongoCollection<TEntity>> WriteAsync<TEntity>()
        where TEntity: IEntity;

    Task<IDatabase> ReadAsync();
}