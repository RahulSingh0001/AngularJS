using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dealer.Models.Dealer.DealerModel;

namespace Dealer.Data.Dealer
{
    public interface IDealerDtlRepository
    {
        Task<IEnumerable<UserDetail>> VerifyOtp(string otp);
        Task<IEnumerable<DealerDtlModel>> Login(string username);
        Task<IEnumerable<LocationDtl>> LocationList(int userId);
        Task<IEnumerable<DealerDtl>> DealerList(int userId, int locationId);
        Task<IEnumerable<CarDtl>> CarDetails(int userId, int locationId, int dealerId);
        Task<IEnumerable<UserDetail>> UserLogin(string username);
        Task<IEnumerable<DealerDtlModel>> OtpLogin(string number);
    }
}
