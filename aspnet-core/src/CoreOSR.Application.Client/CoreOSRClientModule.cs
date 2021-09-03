using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CoreOSR
{
    public class CoreOSRClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CoreOSRClientModule).GetAssembly());
        }
    }
}
