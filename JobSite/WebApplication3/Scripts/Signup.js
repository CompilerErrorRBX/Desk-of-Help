$("#submit").click(function () {
	var firstN = $("#fname").val()
	var lastN = $("#lname").val()
	var email = $("#email").val()
	var pass = $("#password").val()
	var Cpass = $("#confirmPassword").val()
	if (pass !== Cpass) {
		alert("Sorry, your passwords don't match. Please try again.")
		return
	}

	var salt = generateSalt()
	var saltPass = pass + salt
	var finalPass = sha256(saltPass)

	$.ajax({
		type: 'POST',
		url: 'Authenticate/createAccount',
		contentType: "application/json; charset=utf-8",
		dataType: 'JSON',
		data: "{'fname' : '" + firstN + "', 'lname' : '" + lastN + "', 'password' : '" + finalPass + "', 'email' : '" + email + "', 'salt' : '" + salt.toString() + "'}",
		success: function () {
			alert("Signup successful")
		}
	})
})


function generateSalt() {
	var c = {};
	for (var i = 0; i < 16; i++) {
		var number = Math.round(Math.random() * 1000)
		c[i] = String.fromCharCode(number);
	}
var salt = new String(c);
return salt;
}