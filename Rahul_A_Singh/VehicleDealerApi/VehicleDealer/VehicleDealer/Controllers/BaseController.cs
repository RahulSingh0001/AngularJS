using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace VehicleDealer.Controllers
{
    [ServiceFilter(typeof(GlobalExceptionFilter))]
    [ApiController]
    public class BaseController : ControllerBase
    {

    }
}