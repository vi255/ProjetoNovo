using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using ProjetoNovo.EntityFramework;

namespace ProjetoNovo
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(ProjetoNovoCoreModule))]
    public class ProjetoNovoDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<ProjetoNovoDbContext>(null);
        }
    }
}
