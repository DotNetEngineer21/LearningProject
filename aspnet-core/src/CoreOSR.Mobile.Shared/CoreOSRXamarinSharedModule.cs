using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CoreOSR
{
    [DependsOn(typeof(CoreOSRClientModule), typeof(AbpAutoMapperModule))]
    public class CoreOSRXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CoreOSRXamarinSharedModule).GetAssembly());
        }
    }
}