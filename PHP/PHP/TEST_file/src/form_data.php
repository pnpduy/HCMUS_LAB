<form method="POST" align="center" action="">
<?php
	echo "<h1 align = 'center'>Please see your information again above"."</h1>";
	echo "<h2 align = 'center'>If you make sure, please press Confirm"."</h2>";
	
	echo "<p align = 'center'>First Name: $firstName</p>";

	echo "<p align = 'center'>Last Name: $lastName</p>";

	echo "<p align = 'center'>Email: $email</p>";

	echo "<p align = 'center'>Re-enter Email: $re_email</p>";

	echo "<p align = 'center'>Password: $password</p>";

	echo "<p align = 'center'>Birthday: $birthday</p>";

	echo "<p align = 'center'>Gender: $gender</p>";
?>
	<input type="submit" class="button3" name="confirm" value="Confirm" />
</form>
