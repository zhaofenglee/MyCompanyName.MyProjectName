using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Autofac;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace MyCompanyName.MyProjectName;

[DependsOn(
    typeof(AbpHttpClientModule),
    typeof(AbpAutofacModule),
    typeof(AbpAspNetCoreMvcModule)

    )]
public class MyProjectNameModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        //PreConfigure<AbpHttpClientBuilderOptions>(options =>
        //{
        //    options.ProxyClientActions.Add((remoteServiceName, clientBuilder, client) =>
        //    {
        //        client.Timeout = TimeSpan.FromMinutes(60);
        //    });
        //});

    }
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var hostenv = context.Services.GetHostingEnvironment();
        var config = context.Services.GetConfiguration();

        context.Services.GetHostingEnvironment();
    }

    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {

    }
}
