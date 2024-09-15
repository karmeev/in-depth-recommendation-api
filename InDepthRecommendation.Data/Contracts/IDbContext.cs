using MongoDB.Driver;

namespace InDepthRecommendation.Data.Contracts;

public interface IDbContext
{
    Task<IMongoCollection<T>> WriteAsync<T>();
}