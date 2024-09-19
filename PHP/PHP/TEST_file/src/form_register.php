<!DOCTYPE html>
<html lang="en" >
<head>
    <link href="css/style_Assignment.css" rel="stylesheet" type="text/css" />
</head>
<body>
<form method = "POST" action="index.php">
	<div id="intro1" class="fb-body">Facebook helps you connect and share with the <br>people in your life.
	</div>
	<div id="intro2" class="fb-body">Create an account</div>
	<div id="img2" class="fb-body"><img src="img/world.png" /></div>
	<div id="intro3" class="fb-body">It's free and always will be.</div>
	<div id="form3" class="fb-body">
		<input placeholder="First Name" type="text" id="namebox" name="name1" />
		<input placeholder="Last Name" type="text" id="namebox" name="name2" /> <br>
		
		<input placeholder="Email" type="text" id="email" class="mailbox" name="register_email"/>
		<span id="error" style="color:red"><?php if(!empty($emailErr)) echo $emailErr; ?></span>
		
		<br><input placeholder="Re-enter email" type="text" id="re_email" class="mailbox" class="mailbox" name="reg_re_email"/>
		<span id="error" style="color:red"><?php if(!empty($re_emailErr)) echo $re_emailErr; ?></span>
		
		<br><input placeholder="Password" type="password" id="pass" class="mailbox" maxlength="25" name = "reg_name" />
		<span id="error" style="color:red"><?php if(!empty($passErr)) echo $passErr; ?></span>
		<br><input placeholder="dd/mm/yyyy" type="date" id="namebox" name = "reg_birthday" />
		<span id="error" style="color:red"><?php if(!empty($birthdayErr)) echo $birthdayErr; ?></span>
		
		<br><br>
		<input type="radio" id="r-b" name="sex" value="male"  />Male
		<input type="radio" id="r-b" name="sex" value="female" />Female<br><br>
		
		<p id="intro4">By clicking Create an account, you agree to our Terms and that you have<br>
		read our Data Policy, including our Cookie Use.</p>
		
		<input type="submit" name ="create_account" class="button2" value="Create an account" />
		<br><hr id="hr">
		<p id="intro5">Create a Page for a celebrity, band or business.</p>
	</div>
</form>
</body>
</html>