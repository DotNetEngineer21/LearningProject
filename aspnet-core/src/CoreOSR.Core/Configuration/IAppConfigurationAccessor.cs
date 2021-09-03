using Microsoft.Extensions.Configuration;

namespace CoreOSR.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
