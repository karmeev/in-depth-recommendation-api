namespace InDepthRecommendation.Services.Settings;

public class DataAccessSettings
{
    public string MongoConnectionString { get; set; } = string.Empty;
    public string RedisConfiguration { get; set; } = string.Empty;
    public string RedisInstanceName { get; set; } = string.Empty;
}