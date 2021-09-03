using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CoreOSR
{
    [DependsOn(typeof(CoreOSRXamarinSharedModule))]
    public class CoreOSRXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CoreOSRXamarinAndroidModule).GetAssembly());
        }
    }
}