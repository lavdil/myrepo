﻿< !DOCTYPE html >
 < html lang = "en" >
  < head >
  
      < meta charset = "UTF-8" >
   
       < meta name = "viewport" content = "width=device-width, initial-scale=1.0" >
      
          < title > Bus Interface </ title >
         
             < style >
                 /* CSS styles */
                 body {
    font - family: Arial, sans - serif;
margin: 0;
padding: 0;
}

        .container
{
    max - width: 800px;
margin: 0 auto;
padding: 20px;
}

h1
{
    text - align: center;
    margin - bottom: 20px;
}

        .input - container {
    margin - bottom: 10px;
}

            .input - container input
{
width: 100 %;
padding: 10px;
    box - sizing: border - box;
    margin - top: 5px;
}

#error-message {
color: red;
text - align: center;
margin - top: 10px;
        }

        #login-button,
        #redirect-button {
            background - color: #4CAF50;
            color: white;
padding: 10px 20px;
border: none;
cursor: pointer;
display: block;
margin: 10px auto;
text - align: center;
text - decoration: none;
        }

            #login-button:hover,
            #redirect-button:hover {
                background - color: #45a049;
            }

        .container,
        h1,
        .input - container,
        #error-message,
        #login-button,
        #redirect-button {
            background - color: rgba(255, 255, 255, 0.8);
            /* Adding a semi-transparent white background for better readability */
        }

        /* Hide login forms by default */
        #admin-login,
        #user-login {
            display: none;
        }
    </ style >
</ head >
< body >
    < div class= "container" >
 
         < h1 > Welcome to Bus Interface</h1>
        <select id="login-role">
            <option value="" disabled selected>Select</option>
            <option value="user">User</option>
            <option value="admin">Admin</option>
        </select>

        <!-- Admin login form -->
        <div id="admin-login">
            <div class= "input-container" >
                < input type = "text" id = "admin-username" placeholder = "Admin Username" >
     
                 </ div >
     
                 < div class= "input-container" >
      
                      < input type = "password" id = "admin-password" placeholder = "Admin Password" >
           
                       </ div >
           
                   </ div >
           

                   < !--User login form -->
        <div id="user-login">
            <div class= "input-container" >
                < input type = "text" id = "user-username" placeholder = "User Username" >
     
                 </ div >
     
                 < div class= "input-container" >
      
                      < input type = "password" id = "user-password" placeholder = "User Password" >
           
                       </ div >
           
                   </ div >
           

                   < button id = "login-button" > Login </ button >
            
                    < div class= "error-message" id = "error-message" style = "display: none;" ></ div >
                

                        < !--Button to redirect to the next page -->
        <a href="#" id="redirect-button" style="display: none;">Go to Next Page</a>
    </div>

    <script>
        document.getElementById('login-button').addEventListener('click', function() {
    var role = document.getElementById('login-role').value;
    var username, password;

    if (role === 'admin')
    {
        username = document.getElementById('admin-username').value;
        password = document.getElementById('admin-password').value;
    }
    else if (role === 'user')
    {
        username = document.getElementById('user-username').value;
        password = document.getElementById('user-password').value;
    }

    // Simulating validation failure if username or password is empty
    if (!username || !password)
    {
        document.getElementById('error-message').textContent = "Username and password are required.";
        document.getElementById('error-message').style.display = 'block';
        document.getElementById('redirect-button').style.display = 'none';
        return; // Stop further execution
    }

    // Clear error message if validation passes
    document.getElementById('error-message').textContent = "";
    document.getElementById('error-message').style.display = 'none';

    // Here, you need to implement AJAX to validate the credentials on the server-side
    // For simplicity, I'll simulate a successful login with correct credentials
    // In your actual application, you need to send a request to the server to verify the credentials

    // Simulating successful login, enable the redirect button
    document.getElementById('redirect-button').style.display = 'block';
});

// Add click event listener to the redirect button
document.getElementById('redirect-button').addEventListener('click', function() {
    // Redirect to the next page
    window.location.href = "/HOMEPAGE_";
});
    </ script >
</ body >
</ html >
