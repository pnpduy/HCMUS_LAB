<?php session_start();
unset($_SESSION["namelogin"]);
unset($_SESSION["passwordlogin"]);
echo "<h4 align = 'center'> You have cleaned session" . "<br>";
header('Refresh: 1; URL = ../Assignment3.php');
