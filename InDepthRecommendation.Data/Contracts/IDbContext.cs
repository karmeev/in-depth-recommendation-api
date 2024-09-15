using InDepthRecommendation.Models.Contracts;
using MongoDB.Driver;

namespace InDepthRecommendation.Data.Contracts;

public interface IDbContext
{
    Task<IMongoCollection<TEntity>> WriteAsync<TEntity>()
        where TEntity: IEntity;
}