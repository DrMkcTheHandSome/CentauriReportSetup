using CentauriReport.Application;
using CentauriReport.Application.Interfaces;
using CentauriReport.Application.Services;
using CentauriReport.Shared.Manager;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentauriReport.API.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, ConnectionString connection)
        {
          services.AddScoped<IAddressService, AddressService>();
          services.AddScoped<IAgencyService, AgencyService>();

            return services;
        }
    }
}
