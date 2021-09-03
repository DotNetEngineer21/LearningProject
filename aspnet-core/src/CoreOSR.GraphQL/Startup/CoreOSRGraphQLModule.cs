using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CoreOSR.Startup
{
    [DependsOn(typeof(CoreOSRCoreModule))]
    public class CoreOSRGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CoreOSRGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}