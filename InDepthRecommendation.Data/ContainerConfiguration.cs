using Autofac;
using InDepthRecommendation.Data.Contracts;
using InDepthRecommendation.Data.Contracts.Repositories;
using InDepthRecommendation.Data.DbContexts;
using InDepthRecommendation.Data.Repositories;

namespace InDepthRecommendation.Data;

public static class ContainerConfiguration
{
    public static void RegisterDataAccessLayer(this ContainerBuilder builder)
    {
        builder.RegisterType<DbContext>().As<IDbContext>();
        builder.RegisterType<MongoDbContext>().AsSelf().InstancePerLifetimeScope();
        
        builder.RegisterRepositories();
    }

    private static void RegisterRepositories(this ContainerBuilder builder)
    {
        builder.RegisterType<RepositoryManager>().AsSelf().InstancePerLifetimeScope();
        builder.RegisterType<UserActionRepository>().As<IUserActionRepository>();
    }
}