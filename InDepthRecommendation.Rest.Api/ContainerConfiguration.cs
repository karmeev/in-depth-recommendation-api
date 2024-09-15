using Autofac;
using InDepthRecommendation.Facade;
using InDepthRecommendation.Facade.Contracts;
using InDepthRecommendation.Rest.Api.Controllers;

namespace InDepthRecommendation.Rest.Api;

public static class ContainerConfiguration
{
    public static void ConfigureContainer(this ContainerBuilder containerBuilder)
    {
        containerBuilder.RegisterControllers();
        containerBuilder.RegisterFacades();
    }

    private static void RegisterControllers(this ContainerBuilder builder)
    {
        builder.RegisterType<UserActionsController>().InstancePerRequest();
        builder.RegisterType<RecommendationController>().InstancePerRequest();
    }

    private static void RegisterFacades(this ContainerBuilder builder)
    {
        builder.RegisterType<UserActionFacade>().As<IUserActionFacade>().InstancePerLifetimeScope();
    }
}