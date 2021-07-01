using AspectCore.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AuditEvent.Net.Extensions.Extensions
{
    public static class HostBuilderExtensions
    {
        public static void UseAuditEvent(this IHostBuilder host)
        {
            host.UseServiceProviderFactory(new DynamicProxyServiceProviderFactory());
        }
    }
}
