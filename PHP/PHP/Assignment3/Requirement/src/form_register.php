<form action="Assignment3.php" method="post" id="form" onsubmit="return validate_all('results');">
    <div id="intro1" class="fb-body">Facebook helps you connect and share with the <br>
        people in your life.</div>
    <div id="intro2" class="fb-body">Create an account</div>
    <div id="img2" class="fb-body"><img src="img/world.png" />
    click here to clean <a href="src/clearSS.php" tite="Logout">Session</a>.
    </div>
    <div id="intro3" class="fb-body">It's free and always will be.</div>
    <div id="form3" class="fb-body">
        <input placeholder="First Name" type="text" id="namebox" name="fname">
        <input placeholder="Last Name" type="text" id="namebox" name="lname"> <br>
        <input placeholder="Email" type="text" id="mailbox" name="email" maxlength="55" onKeyUp="updatelength('email', 'email_length') "><br>
        <div id="email_length"></div>
        <input placeholder="Re-enter email" type="text" id="mailbox" name="reemail"><br>
        <input placeholder="Password" type="password" id="mailbox" name="password"><br>
        <input type="date" id="namebox" name="birth" /><br><br>
        <input type="radio" id="r-b" name="sex" value="1" checked="checked">Male
        <input type="radio" id="r-b" name="sex" value="0" checked="checked">Female<br><br>
        <p id="intro4">By clicking Create an account, you agree to our Terms and that
            you have read our Data Policy, including our Cookie Use.</p>
        <h3 id="results"></h3>
        <input type="submit" class="button2" name="submit2" value="Create an account">
        <br>
        <hr>
        <p id="intro5">Create a Page for a celebrity, band or business.</p>

    </div>

</form>