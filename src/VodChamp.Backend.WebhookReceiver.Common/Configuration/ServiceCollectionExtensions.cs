using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace VodChamp.Backend.WebhookReceiver.Common.Configuration
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Register a configuration section found in the registered IConfiguration instance
        /// </summary>
        /// <param name="containerBuilder">The AutoFac IOC container to resolve/register against</param>
        /// <typeparam name="TOptions">The type of options to register (containing a key)</typeparam>
        /// <returns>The registration data for that instance</returns>
        public static IServiceCollection AddOptionsSection<TOptions>(this ServiceCollection containerBuilder)
            where TOptions : class, IPrefixedOptions, new()
        {
            return containerBuilder.AddScoped(provider =>
            {
                if (provider.GetService<IConfiguration>() is not IConfigurationRoot config)
                    throw new ArgumentException("No IConfiguration was registered in the ContainerBuilder");

                TOptions options = new();
                config.GetSection(options.ConfigSectionPrefix).Bind(options);

                return options;
            });
        }
    }
}
