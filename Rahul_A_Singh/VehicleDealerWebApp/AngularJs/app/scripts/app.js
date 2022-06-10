const URL = "https://localhost:44329/";
const apiKey = 'hL4bA4nB4yI0fC8fH7eT6';
let app = angular.module('myApp', ['ngRoute'])

app.controller('appController', ($scope, $http, $route, $location) => {
    $route.reload();
    $scope.userName = "";
    $scope.locations = [];
    $scope.title = "Welcome";
    $scope.userId = 0;
    $scope.locId = 0;
    $scope.dealerList = [];
    $scope.carList = [];

    //Login Method
    $scope.login = function (value) {                          
        var username = document.getElementById('userName');
        var password = document.getElementById('password');
        var userName = username.value;
        var passCode = password.value;
        var req = {
            method: 'get',
            url: URL + "DealerDtl/userlogin/"+userName,
            headers: {
                'ApiKey': apiKey
            }
        }
        $http(req)
            .then(function (response) {
                if (response.data.data.length > 0) {
                    if (response.data.data[0].userPass != null || response.data.data[0].userPass != undefined) {
                        var decrypted = CryptoJS.AES.decrypt(response.data.data[0].userPass, "salt");
                        var secondString = decrypted.toString(CryptoJS.enc.Utf8);
                        localStorage.setItem('userName', response.data.data[0].userName);
                        if (passCode == secondString) {
                            $scope.userName = response.data.data[0].userName != null ? response.data.data[0].userName: localStorage.getItem('userName');
                            $scope.userId = response.data.data[0].userId;
                            localStorage.setItem('userId', response.data.data[0].userId);
                            $scope.GetLocation(response.data.data[0].userId != null ? response.data.data[0].userId : localStorage.getItem('userId'));
                            window.location.href = '#!dealer';                                              
                        }
                        else {
                            window.location.href = '#!login';
                        }
                    }

                }
            })    
     
    }

    //Otp Message Generator
    $scope.GetMessage = function (value) {
        var button = document.getElementById('otpBtn');
        var numb = button.value;
        number = numb;

        var req = {
            method: 'get',
            url: URL + "DealerDtl/otplogin/" + numb,
            headers: {
                'ApiKey': apiKey
            }
        }
        $http(req)
            .then(function (response) {
                if (response.data != null) {
                    window.location.href = '#!verifyotp';
                }
                else {
                    window.location.href = '#!login';
                }
            })
    }


    //VerifyOtp
    $scope.VerifyOTP = function (value) {
        var button = document.getElementById('otpData');
        var otpValue = button.value;   
        var req = {
            method: 'get',
            url: URL + "DealerDtl/verifyOtp/" + otpValue,
            headers: {
                'ApiKey': apiKey
            }
        }
        $http(req)
            .then(function (response) {
                if (response.data.data.length > 0) {
                    if (response.data.data[0].userName != null || response.data.data[0].userName != undefined) {
                        $scope.userName = response.data.data[0].userName != null ? response.data.data[0].userName : localStorage.getItem('userName');
                        $scope.userId = response.data.data[0].userId;
                        $scope.GetLocation(response.data.data[0].userId != null ? response.data.data[0].userId : localStorage.getItem('userId'));
                        window.location.href = '#!dealer';
                    }

                }
                else {
                    window.location.href = '#!login';
                }
            })
    }

    $scope.logout = function () {
        localStorage.clear();
    }


    //Dealer Location
    $scope.GetLocation = function () {
        var locReq = {
            method: 'get',
            url: URL + "DealerDtl/location/" + ($scope.userId != null && $scope.userId>0 ? $scope.userId : localStorage.getItem('userId')),
            headers: {
                'ApiKey': apiKey
            }
        }
        $http(locReq)
            .then(function (response) {
                if (response.data.data.length > 0) {                        
                    window.location.href = '#!dealer';
                    $scope.userName = localStorage.getItem('userName') != null ? localStorage.getItem('userName') : "";
                    $scope.locations = response.data.data;
                    $scope.locList = $scope.locations[0];
                    localStorage.setItem('locList', $scope.locList);
                    localStorage.setItem('locId', $scope.locList.locCode);
                    $scope.locId = $scope.locList.locCode != null ? $scope.locList.locCode : localStorage.getItem('locId');
                    $scope.userId = $scope.userId != null && $scope.userId > 0 ? $scope.userId : localStorage.getItem('userId');
                    $scope.locChange($scope.locList != null ? $scope.locList : localStorage.getItem('locList'));
                }
                else {
                    window.location.href = '#!login';
                }
            })

    }


    //If location Change data will change
    $scope.locChange = function (value) {
        console.log(value);
        var locReq = {
            method: 'get',
            url: URL + "DealerDtl/dealerList/" + ($scope.userId != null && $scope.userId > 0 ? $scope.userId : localStorage.getItem('userId')) + "/" + (value.locCode != null && value.locCode >0 ? value.locCode: localStorage.getItem('locId')),
            headers: {
                'ApiKey': apiKey
            }
        }
        $http(locReq)
            .then(function (response) {
                if (response.data.data.length > 0) {                    
                    $scope.locList = value != null ? value : localStorage.getItem('locList');
                    $scope.locId = value.locCode != null ? value.locCode : localStorage.getItem('locId');
                    window.location.href = '#!dealer';
                    $scope.dealerList = response.data.data;
                    $scope.dealer = $scope.dealerList[0];
                }
                else {
                    window.location.href = '#!login';
                }
            })

    }


    //Method for selected dealer
    $scope.dealerSelected = function (dealerId, dealerName) {
        localStorage.setItem('dealerId', dealerId);
        localStorage.setItem('dealerName', dealerName);
        $scope.Name = $scope.userName;        
        var locReq = {
            method: 'get',
            url: URL + "DealerDtl/cardetails/" + ($scope.userId != null && $scope.userId > 0 ? $scope.userId : localStorage.getItem('userId')) + "/" + ($scope.locId != null && $scope.locId ? $scope.locId : localStorage.getItem('locId')) + "/" + dealerId,
            headers: {
                'ApiKey': apiKey
            }
        }
        $http(locReq)
            .then(function (response) {
                if (response.data.data.length > 0) {
                    $scope.Name = localStorage.getItem('userName') != null ? localStorage.getItem('userName') : "";
                    $scope.dealerName = dealerName;
                    $scope.carList = response.data.data;
                    window.location.href = '#!dashboard';                   
                }
                else {
                    window.location.href = '#!login';
                }
            })

    }



    //Check for route method
    var route = $location.path();
    if (route == "/dealer") {
        $scope.GetLocation();
    }  
    if (route == "/dashboard") {
        if ($scope.dealerId == undefined || $scope.dealerId == 0) {
            $scope.dealerIdTemp = localStorage.getItem('dealerId');
            $scope.dealerNameTemp = localStorage.getItem('dealerName');
            $scope.dealerSelected($scope.dealerIdTemp, $scope.dealerNameTemp);
        }
        
    }  
    
})



app.controller('loginController', ($scope, $http) => {
    $scope.title = "login";
    console.log($scope.title)
})


app.config(function ($routeProvider) {
    $routeProvider
        .when("/", {
            templateUrl: "app/views/login.view.html"
        })
        .when("/otp", {
            templateUrl: "app/views/otp.view.html"
        })
        .when("/verifyotp", {
            templateUrl: "app/views/verifyotp.view.html"
        })
        .when("/dashboard", {
            templateUrl: "app/views/dashboard.view.html"
        })
        .when("/dealer", {
            templateUrl: "app/views/dealer.view.html"
        })
        .when("/login", {
            templateUrl: "app/views/login.view.html"
        });
});




