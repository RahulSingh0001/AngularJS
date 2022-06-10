"use strict";
app.controller("userController", [
    "$scope",
    "userService",
    function ($scope, userService) {        
        $scope.users = [];
        $scope.user = {};

        $scope.getUsers = function () {
            var promice = userService.getUsers();
            promice.then(res => {
                $scope.users = res.data;
            });
        }
        $scope.getUsers();

        $scope.addUser = function () {
            $scope.user = {};
        }

        $scope.saveUser = function () {
            var promice = userService.addUser($scope.user);
            promice.then(res => {
                alert("ok");
            });
        }        

        $scope.editUser = function (user) {
            $scope.user = user;
        }

        $scope.deleteUser = function (id) {
            console.log(id);
        }
    }
]);
