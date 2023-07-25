using System;
using AsaasClient.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AsaasClient
{
    public static class AsaasDomainDependencyInjection
    {
        public static IServiceCollection AddAsaas(this IServiceCollection services, IConfiguration configuration, ApiSettings settings = null)
        {
            var asaasConfig = configuration.GetSection("ASAAS");

            settings ??= new ApiSettings(asaasConfig["AccessToken"], asaasConfig["BaseUrl"] ?? "https://www.asaas.com");


            services
                .AddSingleton(settings)
                .AddScoped<IAsaasService, AsaasApi>();
            
            return services;
        }

    }
}