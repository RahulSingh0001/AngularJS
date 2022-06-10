var number = "";
function GetMessage(value) {
    var button = document.getElementById('otpBtn');
    var numb = button.value;
    number = numb;
    $.get("https://localhost:5001/PaymentDtl/getCardDtls/" + numb + "", function (data) {
        if (data != null) {
            window.location.href ="verifyotp.view.html"
        }           
    });
}

function VerifyOTP(value) {
    var button = document.getElementById('otpData');
    var otpValue = button.value;
    $.get("https://localhost:5001/PaymentDtl/verifyOtp/" + otpValue + " ", function (data) {
        if (data.data.length > 0) {
            if (data.data[0].userName != null || data.data[0].userName != undefined) {                
                window.location.href = 'app/view/dashboard.view.html';               
            }
        
        }
        else {
            window.location.href = '#!login';
        }
     
        $("p").html(data);
        console.log(data);
    });
}


function Login(value) {
    var username = document.getElementById('userName');
    var password = document.getElementById('password');
    $.get("https://localhost:5001/PaymentDtl/login/" + username.value + " ", function (data) {
        if (data.data.length > 0) {
            if (data.data[0].pass != null || data.data[0].pass != undefined) {
                var decrypted = CryptoJS.AES.decrypt(data.data[0].pass, "salt");
                 var secondString = decrypted.toString(CryptoJS.enc.Utf8);
                if (password.value == secondString) {
                    window.location.href = 'app/views/dashboard.view.html';
                    $("user").html(data.data[0].userName)
                }
                else {
                    window.location.href = '#!login';
                }
            }

        }
        else {
            window.location.href = '#!login';
        }
     
    });
 


   
}

