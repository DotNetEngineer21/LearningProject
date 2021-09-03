using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using CoreOSR.Configure;
using CoreOSR.Startup;
using CoreOSR.Test.Base;

namespace CoreOSR.GraphQL.Tests
{
    [DependsOn(
        typeof(CoreOSRGraphQLModule),
        typeof(CoreOSRTestBaseModule))]
    public class CoreOSRGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CoreOSRGraphQLTestModule).GetAssembly());
        }
    }
}