const loginForm = document.getElementById("login-form");
const loginButton = document.getElementById("login-form-submit");
loginButton.addEventListener("click", (e) => {
    e.preventDefault();
    var userName = loginForm.userName.value;
    var password = loginForm.password.value;
    fetch('http://10.50.17.10:15001/api/user/login', {
        method: 'POST',
        body: JSON.stringify({
            userName:userName,
            password:password
        }),
        headers: {
          'Content-type': 'application/json; charset=UTF-8',
        }
        })
        .then(function(response){ 
        return response.json()})
        .then(function(data)
        {
        console.log(data)
        userName=document.getElementById("userName")
        password=document.getElementById("password")
        userName.innerHTML = data.userName
        password.innerHTML = data.password  
      }).catch(error => console.error('Error:', error)); 
})
