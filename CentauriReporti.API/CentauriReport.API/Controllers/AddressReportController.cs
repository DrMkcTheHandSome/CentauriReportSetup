using CentauriReport.Application.Interfaces;
using CentauriReport.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentauriReport.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressReportController : ControllerBase
    {
       
        private readonly ILogger<AddressReportController> _logger;
        private readonly IAddressService _addressService;

        public AddressReportController(ILogger<AddressReportController> logger,
           IAddressService addressService)
        {
            _addressService = addressService ?? throw new ArgumentNullException(nameof(addressService));
        }

        [HttpGet("")]
        public async Task<ActionResult<List<AddressViewModel>>> GetAddress()
        {
            try
            {
                var result = await _addressService.GetAddresses();
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
