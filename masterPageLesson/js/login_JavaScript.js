//משתנים גלובלים
var nameFlage = false;
var passwordFlage = false;


function checkLogin() {
    if (nameFlage && passwordFlage)
        return true;
    return false;
}



function checkName() {
    var name = document.getElementById("name").value;
    var vName = document.getElementById("vName");

    if (name.length < 3) {
        vName.innerHTML = "enter at least 3 characters";
        vName.style.color = "red";
        vName.style.fontSize = "x-large";
        nameFlage = false;
        return;
    }
    vName.innerHTML = "";
    nameFlage = true;

}


function checkPassword() {
    var password = document.getElementById("password").value;
    var vPassword = document.getElementById("vPassword");

    if (!(password.length >= 8 && password.length <= 50)) {
        vPassword.innerHTML = "8-50";
        vPassword.style.color = "red";
        vPassword.style.fontSize = "x-large";
        passwordFlage = false;
        return;
    }
    vPassword.innerHTML = "";
    passwordFlage = true;

}