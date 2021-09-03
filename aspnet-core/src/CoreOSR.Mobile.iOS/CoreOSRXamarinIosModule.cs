using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CoreOSR
{
    [DependsOn(typeof(CoreOSRXamarinSharedModule))]
    public class CoreOSRXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CoreOSRXamarinIosModule).GetAssembly());
        }
    }
}