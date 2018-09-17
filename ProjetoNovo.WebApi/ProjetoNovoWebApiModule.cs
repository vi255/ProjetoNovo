using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace ProjetoNovo
{
    [DependsOn(typeof(AbpWebApiModule), typeof(ProjetoNovoApplicationModule))]
    public class ProjetoNovoWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(ProjetoNovoApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
