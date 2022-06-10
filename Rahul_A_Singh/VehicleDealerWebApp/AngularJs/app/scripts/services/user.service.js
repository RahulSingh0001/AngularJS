"use strict";
app.service("userService", [
    "$http",
    function ($http) {
        var apiBaseUrl = "http://localhost:11295/api/";
        
        this.getUsers = function (params) {
            return $http({
                method: "GET",
                url: apiBaseUrl + "user",
                params: params
            });
        }

        this.getUserById = function (id) {
            return $http({
                method: "GET",
                url: apiBaseUrl + "user/" + id,
                params: {}
            });
        };

        this.addUser = function (data) {
            return $http({
                method: "POST",
                url: apiBaseUrl + "user",
                data: data
            });
        }

        this.editUser = function (id, data) {
            return $http({
                method: "PUT",
                url: apiBaseUrl + "user/" + id,
                data: data
            });
        }

        this.deleteUser = function (id) {
            return $http({
                method: "DELETE",
                url: apiUrl + apiEndpoint + "user/" + id,
                params: {}
            });
        }
    }
]);
