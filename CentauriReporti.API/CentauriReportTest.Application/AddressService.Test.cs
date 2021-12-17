using CentauriReport.Application;
using CentauriReport.Application.Services;
using CentauriReport.Shared.Manager;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CentauriReportTest.Application
{
    public class AddressServiceTest
    {
        private readonly AddressService _sut;
        private readonly AgencyService _agencyService = new AgencyService();
        private readonly IConfiguration _config = Configuration.GetConfiguration();
        private readonly ConnectionString _connectionString = ConnectionString.GetState();
        public AddressServiceTest()
        {
             _sut = new AddressService(_agencyService);
            _connectionString.CentauriBillingConnection = _config["CentauriBillingConnectionString"];
            _connectionString.CentauriConnection = _config["CentauriConnectionString"];
            _connectionString.CentauriRaterConnection = _config["CentauriRaterConnectionString"];
        }

        [Fact]
        public async Task GetAddress_ShouldReturnAddressList()
        {
            // Arrange

            //Act
            var result = await _sut.GetAddresses();
            //Assert
            Assert.True(result.Count() > 0);
        }
    }
}
