using InDepthRecommendation.Services.Settings;
using StackExchange.Redis;

namespace InDepthRecommendation.Data.DbContexts;

public class RedisDbContext(DataAccessSettings settings): IAsyncDisposable
{
    private ConnectionMultiplexer RedisConnection { get; set; }

    public IDatabase GetCollection()
    {
        return RedisConnection.GetDatabase();
    }
    
    public async Task StartSession()
    {
        RedisConnection = await ConnectionMultiplexer.ConnectAsync(settings.RedisConfiguration);
    }
    
    private async Task CloseSession()
    {
        await RedisConnection.CloseAsync();
    }

    public async ValueTask DisposeAsync()
    {
        await CloseSession();
    }
}