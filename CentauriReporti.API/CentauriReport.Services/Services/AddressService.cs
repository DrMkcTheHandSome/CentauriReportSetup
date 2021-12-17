using CentauriReport.Application.Interfaces;
using CentauriReport.Shared.Manager;
using CentauriReport.Shared.ViewModels;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentauriReport.Application
{
    public class AddressService : IAddressService
    {
        private readonly ConnectionString _connectionString = ConnectionString.GetState();
        private readonly IAgencyService _agencyService;
        public AddressService(IAgencyService agencyService)
        {
            _agencyService = agencyService;
        }
  

        public async Task<List<AddressViewModel>> GetAddresses()
        {
            string sql = @"SELECT * from [Address]";
            try
            {
                using (var connection = new SqlConnection(_connectionString.CentauriConnection))
                {
                    var addresses = await connection.QueryAsync<AddressViewModel>(sql);
                    return addresses.ToList();
                }
            }catch
            {
                throw;
            }
           
        }
    }
}
