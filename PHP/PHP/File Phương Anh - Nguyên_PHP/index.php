<?php
ob_start();
session_start();
// set error reporting level
if (version_compare(phpversion(), '5.3.0', '>=') == 1)
	error_reporting(E_ALL & ~E_NOTICE & ~E_DEPRECATED);
else
	error_reporting(E_ALL & ~E_NOTICE);
?>
<?php include "src/header.php"; ?>
<?php //$path = "C:\\xampp\\htdocs\\PHP\\Requirement\\DataAccountFB.txt"; 
?>

<?php
//ham test_input thuc hien cac ham de tranh nguy co bi hack
function test_input($data)
{
	$data = trim($data); //xoa khoang trang dau cuoi
	$data = stripslashes($data); //xoa cac dau comment
	$data = htmlspecialchars($data); //chuyen cac ky tu dac biet thanh ky tu html
	$data = strip_tags($data);
	return $data;
}
?>

<?php
$user_login = '';
$user_password = '';
if (isset($_POST['login'])) {
	if (!empty($_POST['name'])) {
		$user_login = test_input($_POST['name']);
	}
	if (!empty($_POST['password'])) {
		$user_password = test_input($_POST['password']);
	}
}
?>

<div class="fb-header">
	<div id="img1" class="fb-header"><img src="img/facebook.png" /></div>
	<?php
	if (empty($user_login) || empty($user_password)) {
		include "src/form_login.php";
	}
	?>
</div>

<div class="fb-body">
	<?php
	$firstName = '';
	$lastName = '';
	$email = '';
	$re_email = '';
	$password = '';
	$birthday = '';
	$gender = '';




	$emailErr = $re_emailErr = $passErr = $birthdayErr = '';
	//Dung  mot bien de xac dinh co loi hay khong.
	$error = 0; //Khong co loi
	if (isset($_POST['create_account'])) {
		if (!empty($_POST['name1']))
			$firstName = test_input($_POST['name1']);
		if (!empty($_POST['name2']))
			$lastName = test_input($_POST['name2']);

		if (!empty($_POST['register_email']))
			$email = test_input($_POST['register_email']);
		if (!preg_match("/^[a-zA-Z0-9\-\.]+@[a-zA-Z0-9\-]+\.[a-zA-Z0-9\-\.]+$/", $email)) {
			$emailErr = 'Email is wrong';
			$error = 1; //Co loi xay ra
		}
		if (!empty($_POST['reg_re_email']))
			$re_email = test_input($_POST['reg_re_email']);
		if ($email != $re_email) {
			$re_emailErr = 'Email are not the same';
			$error = 1; //Co loi xay ra
		}
		if (!empty($_POST['reg_name']))
			$password = test_input($_POST['reg_name']);

		if (strlen($password) < 6 or strlen($password) > 15 or (!preg_match("/^[a-zA-Z0-9]+$/", $password))) {
			$passErr = 'Password is wrong';
			$error = 1; //Co loi xay ra
		}

		if (!empty($_POST['reg_birthday']))
			$birthday = test_input($_POST['reg_birthday']);

		$timenow = date("Y-m-d");
		$newtime1 = strtotime('+13 year', strtotime($birthday)); //cong them 13 nam cho birthday
		$newtime2 = strtotime('+117 year', strtotime($birthday)); //cong them 13 nam cho birthday

		//Tuoi phai trong pham vi [13; 117) thi moi hop le 
		if (
			$newtime1 > strtotime($timenow) || $newtime2 <= strtotime($timenow)
			|| empty($birthday) || isValidDate($birthday) == false
		) {
			$birthdayErr = 'Birthday is invalid';
			$error = 1; //Co loi xay ra
		}

		if (!empty($_POST['sex']))
			$gender = test_input($_POST['sex']);
	}
	//chia truong hop dang nhap va dang ky tai khoan 
	$case = 0;
	// if (!empty($user_login) && !empty($user_password)) {
	// 	echo "<h1>1</h1>";
	// 	$case = 1; //truong hop dang nhap tai khoan
	// } else
	if (
		!empty($firstName) && !empty($lastName) && !empty($email) && !empty($re_email) &&
		!empty($password) && !empty($birthday) && !empty($gender)
	) {
		$case = 2; //truong hop dang ky tai khoan
	} elseif (empty($user_login) || empty($password)) {
		$case = 3;
	}

	//$myFile = fopen($path, "a+") or die("Unable to open file!");
	switch ($case) {
		case "0":
			if (!isset($_POST['confirm'])) {
				include "src/form_register.php";
			}
			break;
			//case "1":  //truong hop dang nhap tai khoan
			// $account = 0; //name va password chua dung

			// while (!feof($myFile)) {
			// 	$content = fgets($myFile);
			// 	$content = str_replace(array("\n", "\r"), "", $content);
			// 	$array = explode("|", $content);

			// 	if ($user_login == $array[0] && $user_password == $array[1]) {
			// 		$account = 1; //name va password dung
			// 		//Khi dang nhap dung tai khoan tien hanh luu thong tin login vao session.
			// 		$_SESSION['valid'] = true;
			// 		$_SESSION['timeout'] = time();
			// 		$_SESSION['s_user_login'] = $user_login;

			// 		echo "<p align = 'center'> <b> Welcome $user_login to my facebook" . "<br></p>";
			// 		echo "<p align = 'center'> Click <a href='index.php'> here </a> to logout" . " </p>";
			// 	}
			// }
			// if ($account == 0) {
			// 	echo "<p align = 'center'> <b> Sorry your login information is wrong " . "<br></p>";
			// 	echo "<p align = 'center'> Click <a href='index.php'> here </a> to login again" . " </p>";
			// }


			break;
		case "2":
			if (isset($_POST['create_account'])) {
				if ($error == 0) {
					include "src/form_data.php";
				} else if ($error == 1) {
					include "src/form_register.php";
				}
			}
			break;
		case "3":
			if (!isset($_POST['confirm'])) { //tranh khi bam nut confirm co trang form_register hien ra
				if (isset($_POST['submit1'])) {
					if (!empty($user_login) && empty($user_password)) {
						echo "<p align = 'center'> <b> The Password you entered is incorrect" . "<br></p>";
						echo "<p align = 'center'>You can login again above or Click <a href='index.php'> here </a> 
						to login again" . " </p>";
					} elseif (isset($_SESSION["s_user_login"]) and isset($_SESSION["s_password"])) {
						if ($user_login == $_SESSION["s_user_login"] and $user_password == $_SESSION["s_password"]) {
							echo "<p align = 'center'> <b> Welcome to Facebook" . "<br>";
							echo "Click <a href='index.php'> here </a> to HomePage </p>";
						}
					} else {
						echo "<p align = 'center'> <b> The Email or Phone you entered is not connected 
						to any account" . "<br></p>";
						echo "<p align = 'center'>You can login again above or Click <a href='index.php'> here </a> 
						to login again" . " </p>";
					}
				} else
					include "src/form_register.php";
			}
	}

	if (isset($_POST['confirm'])) {
		echo "<p align = 'center'> <b> Welcome you to my facebook" . "<br></p>";
		echo "<p align = 'center'> Click <a href='index.php'> here </a> to logout" . " </p>";
		$_SESSION["s_user_login"] = $email;
		$_SESSION["s_password"] = $password;
	}
	//fclose($myFile);
	?>
</div>

<?php include "src/footer.php" ?>

<?php
function valid_birthday($user_birthday)
{
	$timenow = date("d");
	echo $timenow;
}
function isValidDate(string $date, string $format = 'Y-m-d'): bool
{
	$dateObj = DateTime::createFromFormat($format, $date);
	return $dateObj && $dateObj->format($format) == $date;
}
?>