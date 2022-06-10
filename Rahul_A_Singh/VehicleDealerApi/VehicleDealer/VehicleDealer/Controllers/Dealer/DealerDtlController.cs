using Dealer.Service.Dealer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dealer.Models.Dealer;
using static Dealer.Models.Dealer.DealerModel;
using Dealer.Models;
using Dealer.Data.Dealer;
using System.Data.SqlClient;
using Dapper;
using Dealer.Data.Constants;
using System.Data;
using Microsoft.Extensions.Configuration;
using Swashbuckle.AspNetCore.Annotations;
using VehicleDealer.Attributes;


namespace VehicleDealer.Controllers.Dealer
{
    [ApiKey]
    [Route("[controller]")]
    [ApiController]
    [SwaggerTag("VehicleDealer")]
    public class DealerDtlController : ControllerBase
    {
        private readonly IDealerDtlService _DealerService;        
        private IConfiguration Configuration;
        public DealerDtlController(IConfiguration _configuration, IDealerDtlService IDealerService)
        {
            _DealerService = IDealerService;
            Configuration = _configuration;
        }


        [Route("login/{username}")]
        public async Task<IActionResult> Login(string username)
        {            
            var result = new GenericResult<dynamic>();
            var data = await _DealerService.Login(username);
            result.Data = data.ToList();
            result.Success = true;
            return Ok(result);

        }

        [Route("location/{userId}")]
        public async Task<IActionResult> LocationList(int userId)
        {
            var result = new GenericResult<dynamic>();
            var data = await _DealerService.LocationList(userId);
            result.Data = data.ToList();
            result.Success = true;
            return Ok(result);

        }

        [Route("dealerList/{userId}/{locationId}")]
        public async Task<IActionResult> DealerList(int userId,int locationId)
        {
            var result = new GenericResult<dynamic>();
            var data = await _DealerService.DealerList(userId, locationId);
            result.Data = data.ToList();
            result.Success = true;
            return Ok(result);

        }

        [Route("carDetails/{userId}/{locationId}/{dealerId}")]
        public async Task<IActionResult> CarDetails(int userId,int locationId,int dealerId)
        {
            var result = new GenericResult<dynamic>();
            var data = await _DealerService.CarDetails(userId, locationId, dealerId);
            result.Data = data.ToList();
            result.Success = true;
            return Ok(result);

        }

        [Route("userlogin/{username}")]
        public async Task<IActionResult> UserLogin(string username)
        {
            var result = new GenericResult<dynamic>();
            var data = await _DealerService.UserLogin(username);
            result.Data = data.ToList();
            result.Success = true;
            return Ok(result);

        }

        [Route("otplogin/{number}")]
        public async Task<IActionResult> OtpLogin(string number)
        {

            var result = new GenericResult<dynamic>();
            var data = await _DealerService.OtpLogin(number);
            result.Data = data.ToList();
            result.Success = true;
            return Ok(result);

        }

        [Route("verifyOtp/{otp}")]
        public async Task<IActionResult> verifyOtp(string otp)
        {

            var result = new GenericResult<dynamic>();
            var data = await _DealerService.VerifyOtp(otp);
            result.Data = data.ToList();
            result.Success = true;
            return Ok(result);

        }
    }
}
