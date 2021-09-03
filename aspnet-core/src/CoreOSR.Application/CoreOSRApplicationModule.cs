using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CoreOSR.Authorization;

namespace CoreOSR
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(CoreOSRCoreModule)
        )]
    public class CoreOSRApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CoreOSRApplicationModule).GetAssembly());
        }
    }
}