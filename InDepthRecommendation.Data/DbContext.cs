using InDepthRecommendation.Services.Settings;
using MongoDB.Driver;

namespace InDepthRecommendation.Data;

public class DbContext
{
    private MongoClient MongoClient { get; set; }

    public DbContext(DataAccessSettings settings)
    {
        MongoClient = new MongoClient(settings.MongoConnectionString);
    }
}