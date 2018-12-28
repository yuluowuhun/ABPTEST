using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using ABPTEST.EntityFramework;

namespace ABPTEST.Migrator
{
    [DependsOn(typeof(ABPTESTDataModule))]
    public class ABPTESTMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ABPTESTDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}