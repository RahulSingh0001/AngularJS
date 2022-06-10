using Dealer.Data.Dealer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dealer.Models.Dealer.DealerModel;

namespace Dealer.Service.Dealer
{
    public class DealerDtlService : IDealerDtlService
    {
        private readonly IDealerDtlRepository _repository;

        public DealerDtlService(IDealerDtlRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<UserDetail>> VerifyOtp(string otp)
        {
            return await _repository.VerifyOtp(otp);
        }
        public async Task<IEnumerable<DealerDtlModel>> Login(string username)
        {
            return await _repository.Login(username);
        }
        public async Task<IEnumerable<LocationDtl>> LocationList(int userId)
        {
            return await _repository.LocationList(userId);
        }
        public async Task<IEnumerable<DealerDtl>> DealerList(int userId, int locationId)
        {
            return await _repository.DealerList(userId, locationId);
        }
        public async Task<IEnumerable<CarDtl>> CarDetails(int userId, int locationId, int dealerId)
        {
            return await _repository.CarDetails(userId, locationId, dealerId);
        }
        public async Task<IEnumerable<UserDetail>> UserLogin(string username)
        {
            return await _repository.UserLogin(username);
        }
        public async Task<IEnumerable<DealerDtlModel>> OtpLogin(string number)
        {
            return await _repository.OtpLogin(number);
        }
    }
}
