using Autofac;
using InDepthRecommendation.Facade;
using InDepthRecommendation.Facade.Contracts;
using InDepthRecommendation.Rest.Api.Controllers;
using InDepthRecommendation.Services;
using InDepthRecommendation.Services.Settings;

namespace InDepthRecommendation.Rest.Api;

public static class ContainerConfiguration
{
    public static void ConfigureContainer(this ContainerBuilder containerBuilder, ServiceSettings settings)
    {
        containerBuilder.RegisterControllers();
        containerBuilder.RegisterFacades();
        containerBuilder.ConfigureContainerSettings(settings);
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