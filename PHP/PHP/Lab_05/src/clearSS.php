<?php session_start();
unset($_SESSION["s_user_login"]);
unset($_SESSION["s_password"]);
echo "<h4 align = 'center'> You have cleaned session" . "<br>";
header('Refresh: 1; URL = ../index.php');
