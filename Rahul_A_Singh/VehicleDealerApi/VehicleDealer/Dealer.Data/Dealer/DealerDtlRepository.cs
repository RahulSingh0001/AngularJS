using Dealer.Data.Constants;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dealer.Models.Dealer.DealerModel;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Dealer.Models.Dealer;

namespace Dealer.Data.Dealer
{
    public class DealerDtlRepository: IDealerDtlRepository
    {
        private IConfiguration Configuration;
        public DealerDtlRepository(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }    

        public async Task<IEnumerable<UserDetail>> VerifyOtp(string otp)
        {
            var message = this.Configuration.GetConnectionString("VehicleDealerConnection");
            List<UserDetail> resultData = null;
            using (SqlConnection con = new SqlConnection(message))
            {
                await con.OpenAsync();
                var param = new DynamicParameters();               

                if (otp != "")
                {
                    param.Add("@OTP", otp);                  
                    Console.WriteLine("SMS sent successfully");
                    var results = await con.QueryAsync(ProcedureName.VerifyUserOtp, param, commandType: CommandType.StoredProcedure);
                    List<UserDetail> returnResult = null;
                    if (!results.IsNull())
                    {
                        returnResult = new List<UserDetail>();
                        foreach (var item in results)
                        {
                            returnResult.Add(new UserDetail()
                            {
                                UserName = Convert.ToString(((IDictionary<string, object>)item)["UserName"]),
                                UserId = Convert.ToInt32(((IDictionary<string, object>)item)["UserId"]),
                                UserMobileNo = Convert.ToString(((IDictionary<string, object>)item)["Mobile"]),
                            });
                        }

                    }
                    resultData = returnResult;                  
                }
                return resultData;
            }
        }


        public async Task<IEnumerable<DealerDtlModel>> Login(string username)
        {
            var message = this.Configuration.GetConnectionString("SecondDefaultConnection");
            List<DealerDtlModel> resultData = null;
            using (SqlConnection con = new SqlConnection(message))
            {
                await con.OpenAsync();
                var param = new DynamicParameters();
                //var result = await con.QueryAsync(ProcedureName.verifyOpt, param, commandType: CommandType.StoredProcedure);


                if (username != "")
                {

                    param.Add("@UserName", username);                            
                    var results = await con.QueryAsync(ProcedureName.loginUser, param, commandType: CommandType.StoredProcedure);
                    List<DealerDtlModel> returnResult = null;
                    if (!results.IsNull())
                    {
                        returnResult = new List<DealerDtlModel>();
                        foreach (var item in results)
                        {

                            returnResult.Add(new DealerDtlModel()
                            {
                                pass = Convert.ToString(((IDictionary<string, object>)item)["Password"]),
                                userName = Convert.ToString(((IDictionary<string, object>)item)["PayUserName"]),

                            });
                        }

                    }
                    resultData = returnResult;
                }
                return resultData;
            }
        }


        public async Task<IEnumerable<LocationDtl>> LocationList(int userId)
        {
            var message = this.Configuration.GetConnectionString("VehicleDealerConnection");
            List<LocationDtl> resultData = null;
            using (SqlConnection con = new SqlConnection(message))
            {
                await con.OpenAsync();
                var param = new DynamicParameters();                
                if (userId != 0)
                {
                    param.Add("@UserId", userId);
                    var results = await con.QueryAsync(ProcedureName.LocationList, param, commandType: CommandType.StoredProcedure);
                    
                    List<LocationDtl> returnResult = null;
                    if (!results.IsNull())
                    {
                        returnResult = new List<LocationDtl>();
                        foreach (var item in results)
                        {

                            returnResult.Add(new LocationDtl()
                            {
                                LocCode = Convert.ToInt32(((IDictionary<string, object>)item)["LocCode"]),
                                LocCity = Convert.ToString(((IDictionary<string, object>)item)["LocCity"]),
                                LocCountry = Convert.ToString(((IDictionary<string, object>)item)["LocCountry"])                                                         
                            });
                        }

                    }
                    resultData = returnResult;
                }
                return resultData;
            }
        }

        public async Task<IEnumerable<DealerDtl>> DealerList(int userId,int locationId)
        {
            var message = this.Configuration.GetConnectionString("VehicleDealerConnection");
            List<DealerDtl> resultData = null;
            using (SqlConnection con = new SqlConnection(message))
            {
                await con.OpenAsync();
                var param = new DynamicParameters();
                if (userId != 0)
                {
                    param.Add("@UserId", userId);
                    param.Add("@LocationId", locationId);
                    var results = await con.QueryAsync(ProcedureName.DealerList, param, commandType: CommandType.StoredProcedure);

                    List<DealerDtl> returnResult = null;
                    if (!results.IsNull())
                    {
                        returnResult = new List<DealerDtl>();
                        foreach (var item in results)
                        {

                            returnResult.Add(new DealerDtl()
                            {
                                DealerId = Convert.ToInt32(((IDictionary<string, object>)item)["DealerId"]),
                                DealerName = Convert.ToString(((IDictionary<string, object>)item)["DealerName"]),
                                DealerAddress = Convert.ToString(((IDictionary<string, object>)item)["DealerAddress"])
                            });
                        }

                    }
                    resultData = returnResult;
                }
                return resultData;
            }
        }

        public async Task<IEnumerable<CarDtl>> CarDetails(int userId, int locationId, int dealerId)
        {
            var message = this.Configuration.GetConnectionString("VehicleDealerConnection");
            List<CarDtl> resultData = null;
            using (SqlConnection con = new SqlConnection(message))
            {
                await con.OpenAsync();
                var param = new DynamicParameters();
                if (userId != 0)
                {
                    param.Add("@UserId", userId);
                    param.Add("@LocationId", locationId);
                    param.Add("@DealerId", dealerId);
                    var results = await con.QueryAsync(ProcedureName.CarData, param, commandType: CommandType.StoredProcedure);

                    List<CarDtl> returnResult = null;
                    if (!results.IsNull())
                    {
                        returnResult = new List<CarDtl>();
                        foreach (var item in results)
                        {

                            returnResult.Add(new CarDtl()
                            {
                                CarInShowroom = Convert.ToInt32(((IDictionary<string, object>)item)["CarInShowroom"]),
                                CarTestDrive = Convert.ToInt32(((IDictionary<string, object>)item)["CarTestDrive"]),
                                CarAge = Convert.ToInt32(((IDictionary<string, object>)item)["CarAgeInShowroom"]),
                                CarInDemo = Convert.ToInt32(((IDictionary<string, object>)item)["CarInDemo"]),
                                CarName = Convert.ToString(((IDictionary<string, object>)item)["CarName"]),
                                CarInStock = Convert.ToString(((IDictionary<string, object>)item)["CarInStock"])
                            });
                        }

                    }
                    resultData = returnResult;
                }
                return resultData;
            }
        }

        public async Task<IEnumerable<UserDetail>> UserLogin(string username)
        {
            var message = this.Configuration.GetConnectionString("VehicleDealerConnection");
            List<UserDetail> resultData = null;
            using (SqlConnection con = new SqlConnection(message))
            {
                await con.OpenAsync();
                var param = new DynamicParameters();
               
                if (username != "")
                {

                    param.Add("@UserName", username);
                    var results = await con.QueryAsync(ProcedureName.UserLoginDealer, param, commandType: CommandType.StoredProcedure);
                    List<UserDetail> returnResult = null;
                    if (!results.IsNull())
                    {
                        returnResult = new List<UserDetail>();
                        foreach (var item in results)
                        {

                            returnResult.Add(new UserDetail()
                            {
                                UserPass = Convert.ToString(((IDictionary<string, object>)item)["UserPassword"]),
                                UserId = Convert.ToInt32(((IDictionary<string, object>)item)["UserId"]),
                                UserName = Convert.ToString(((IDictionary<string, object>)item)["UserName"]),

                            });
                        }

                    }
                    resultData = returnResult;
                }
                return resultData;
            }
        }

        public async Task<IEnumerable<DealerDtlModel>> OtpLogin(string mobNumbers)
        {
            var message = this.Configuration.GetConnectionString("VehicleDealerConnection");  
            using (SqlConnection con = new SqlConnection(message))
            {
                await con.OpenAsync();
                var param = new DynamicParameters();
                
                Random random = new Random();
                string otp = string.Empty;
                otp = (random.Next(100000, 999999)).ToString();
                var number = mobNumbers;              
                var auth = this.Configuration.GetConnectionString("authId");
                var url = this.Configuration.GetConnectionString("baseUrl");
                var mssgSend = "Hi your One-Time Password for login is";
                var routeId = this.Configuration.GetConnectionString("route");              
                string baseurl = url + auth + "&route=" + routeId + "&message= " + mssgSend + "" + otp + "&language=english&flash=0&numbers=" + number + "";
                WebRequest request = HttpWebRequest.Create(baseurl);
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                var urlText = reader.ReadToEnd();
                string str = urlText;
                var myJson = JsonConvert.DeserializeObject<Item>(str);
                var tempVal = myJson.message[0];

                if ((string)tempVal == "SMS sent successfully.")
                {

                    param.Add("@OTP", otp);
                    param.Add("@MobileNo", number);
                    
                }
                var results = await con.QueryAsync(ProcedureName.InsertUserOtp, param, commandType: CommandType.StoredProcedure);
                List<DealerDtlModel> returnResult = null;
                if (!results.IsNull())
                {
                    returnResult = new List<DealerDtlModel>();
                    foreach (var item in results)
                    {

                        returnResult.Add(new DealerDtlModel()
                        {                            
                            expiryDate = Convert.ToString(((IDictionary<string, object>)item)["SUCCESS"]).Trim(),                         

                        });
                    }

                }
                return returnResult;
            }
        }

    }
}
