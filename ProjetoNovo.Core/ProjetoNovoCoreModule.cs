using System.Reflection;
using Abp.Modules;

namespace ProjetoNovo
{
    public class ProjetoNovoCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
