$("#login").click(function () {
	var username = $("#username").val()
	var password = $("#password").val()
	$.ajax({
		type: 'POST',
		url: 'Authenticate/IsAuthenticated',
		contentType: "application/json; charset=utf-8",
		dataType: 'JSON',
		data: "{'username' : '" + username + "', 'pwd' : '" + password +"'}",
		success: function () {
			alert("login successful")
		}
	})
})