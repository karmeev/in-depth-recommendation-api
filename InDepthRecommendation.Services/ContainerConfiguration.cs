using Autofac;
using InDepthRecommendation.Services.Settings;

namespace InDepthRecommendation.Services;

public static class ContainerConfiguration
{
    public static void ConfigureContainerSettings(this ContainerBuilder containerBuilder, ServiceSettings settings)
    {
        containerBuilder.RegisterInstance(settings.DataAccessSettings);
    }
}