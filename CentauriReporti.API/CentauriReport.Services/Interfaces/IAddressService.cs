using CentauriReport.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentauriReport.Services.Interfaces
{
   public interface IAddressService
    {
        List<AddressViewModel> GetAddresses();
    }
}
