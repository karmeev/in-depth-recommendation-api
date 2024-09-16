using InDepthRecommendation.Services.Settings;

namespace InDepthRecommendation.Rest.Api.Configuration;

public static class ServiceCollectionConfiguration
{
    public static void ConfigureServiceCollection(this IServiceCollection service, ServiceSettings settings)
    {
        service.AddSwaggerGen()
            .AddEndpointsApiExplorer()
            .AddControllers();
        
        //service.ConfigureCaching(settings.DataAccessSettings);
    }

    private static void ConfigureCaching(this IServiceCollection service, DataAccessSettings settings)
    {
        service.AddStackExchangeRedisCache(options =>
        {
            options.Configuration = settings.RedisConfiguration;
            options.InstanceName = settings.RedisInstanceName;
        });
    }
}