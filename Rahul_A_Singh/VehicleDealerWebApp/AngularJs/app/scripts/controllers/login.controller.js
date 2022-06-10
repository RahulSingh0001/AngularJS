"use strict";
app.controller("loginController", [
    "$scope",
    "loginService",
    "sharedProperties",
    
    function ($scope,$rootscope, loginService,sharedProperties) {        
        $scope.loginForm = {
            username: "",
            password: ""
        }
     
        $scope.login = function (value) {
            $scope.both = sharedProperties.getProperty() +'DealerDtl/location/2';
            $scope.envirnoment = $rootscope.env;
            console.log($scope.envirnoment)
            console.log($scope.both)
            var res = loginService.login(value);
            alert(res);
        }
    }
]);
