using CentauriReport.Services.Interfaces;
using CentauriReport.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentauriReport.Services
{
    public class AddressService : IAddressService
    {
        public List<AddressViewModel> GetAddresses()
        {
            return new List<AddressViewModel>() { new AddressViewModel
            {
               Id = Guid.NewGuid(),
               StreetAddress1 = "123",
               StreetAddress2 = "Chico,",
               City = "California",
               County = "PH"
           } 
            };
        }
    }
}
