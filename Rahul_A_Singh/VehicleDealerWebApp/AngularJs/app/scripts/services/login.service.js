"use strict";
app.service("loginService", [
    "$http",
    function ($http) {

        this.login = function (value) {
            console.log(value)
            this.httpClient.get(`${environment.apiUrl}PaymentDtl/getCardDtls`)
            if (username == 'a' && password == '1')
                return "Login success";
            else
                return "Login failed";
        }
    }
]);
