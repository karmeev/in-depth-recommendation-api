using InDepthRecommendation.Data.Contracts;
using InDepthRecommendation.Models.Contracts;
using InDepthRecommendation.Services.Settings;
using MongoDB.Driver;

namespace InDepthRecommendation.Data.DbContexts;

public class MongoDbContext
{
    private IMongoClient MongoClient { get; set; }
    private IMongoDatabase MongoDatabase { get; set; }

    public MongoDbContext(DataAccessSettings settings)
    {
        MongoClient = new MongoClient(settings.MongoConnectionString);
        MongoDatabase = MongoClient.GetDatabase("InDepthRecommendation");
    }

    public async Task StartSession()
    {
        await MongoClient.StartSessionAsync();
    }

    public IMongoCollection<T> GetCollection<T>()
    where T: IEntity
    {
        var entityName = typeof(T).Name;
        return MongoDatabase.GetCollection<T>(entityName);
    }
}