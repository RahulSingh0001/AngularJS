using Dealer.Data.Dealer;
using Dealer.Service.Dealer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using VehicleDealer.Controllers.Dealer;
using Xunit;
using static Dealer.Models.Dealer.DealerModel;
using Xunit.Abstractions;

namespace VehicleDealerApi.Test
{
    public class DealerControllerTest
    {
        DealerDtlController _controller;
        private readonly IDealerDtlService _DealerService;
        private IConfiguration Configuration;
        private readonly IDealerDtlRepository _repository;

        public DealerControllerTest()
        {
            _DealerService = new DealerDtlService(_repository);
            _controller = new DealerDtlController(Configuration, _DealerService);
        }

        [Fact]
        public void OtpGenerator()
        {
            var number = "7979988172";
            var result = _DealerService.OtpLogin(number);
            Assert.NotNull(result);
            Console.WriteLine(result);               

        }
    }
}
