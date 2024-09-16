using Autofac;
using Autofac.Extensions.DependencyInjection;
using InDepthRecommendation.Rest.Api;
using InDepthRecommendation.Rest.Api.Configuration;
using InDepthRecommendation.Services.Settings;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);

var settings = builder.Configuration.Get<ServiceSettings>();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    containerBuilder.ConfigureContainer(settings);
});

builder.Services.ConfigureServiceCollection(settings);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();