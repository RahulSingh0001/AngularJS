using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealer.Models.Dealer
{
    public class DealerModel
    {
        public class DealerDtlModel
        {
            public string userName { get; set; }
            public string cardNumber { get; set; }
            public int cvv { get; set; }
            public string expiryDate { get; set; }
            public int userId { get; set; }
            public int LocationId { get; set; }
            public int DealerId { get; set; }
            public string otp { get; set; }            
            public string pass { get; set; }
            public bool isTrue { get; set; }
        }
        public class cardDtlUser
        {
            public string userName { get; set; }      
        }

        public class LocationDtl
        {
            public int LocCode { get; set; }
            public string LocCity { get; set; }
            public string LocCountry { get; set; }
        }
        public class DealerDtl
        {
            public int DealerId { get; set; }
            public string DealerName { get; set; }
            public string DealerAddress { get; set; }
        }
        public class CarDtl
        {
            public int CarInShowroom { get; set; }
            public int CarTestDrive { get; set; }
            public int CarInDemo { get; set; }          
            public string CarName { get; set; }
            public string CarInStock { get; set; }
            public int CarAge { get; set; }
        }

        public class UserDetail
        {
            public int UserId { get; set; }         
            public string UserName { get; set; }
            public string UserPass { get; set; }
            public string UserMobileNo { get; set; }
        }
    }
}
