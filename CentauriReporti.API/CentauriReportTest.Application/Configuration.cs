using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentauriReportTest.Application
{
    public static class Configuration
    {
        public static IConfiguration GetConfiguration()
        {
            var config = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", false, true)
    .Build();
            return config;
        }
    }
}
