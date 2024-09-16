using Autofac;
using InDepthRecommendation.Data.ClassMaps;
using InDepthRecommendation.Data.Contracts;
using InDepthRecommendation.Data.Contracts.Repositories;
using InDepthRecommendation.Data.DbContexts;
using InDepthRecommendation.Data.Repositories;

namespace InDepthRecommendation.Data;

public static class ContainerConfiguration
{
    public static void RegisterDataAccessLayer(this ContainerBuilder builder)
    {
        builder.RegisterType<DbContext>().As<IDbContext>().InstancePerLifetimeScope();
        builder.RegisterType<MongoDbContext>().AsSelf();
        builder.RegisterType<RedisDbContext>().AsSelf();
        BsonClassMapExtension.RegisterClassMap();
        
        builder.RegisterRepositories();
    }

    private static void RegisterRepositories(this ContainerBuilder builder)
    {
        builder.RegisterType<RepositoryManager>().AsSelf().InstancePerLifetimeScope();
        builder.RegisterType<UserActionRepository>().As<IUserActionRepository>();
    }
}