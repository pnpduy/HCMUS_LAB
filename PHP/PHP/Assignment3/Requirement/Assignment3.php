<?php
session_start();
include "src/header.php";
?>

<?php
if (isset($_POST['namelogin'])) {
    $user_login = $_POST['namelogin'];
}
if (isset($_POST['passwordlogin'])) {
    $user_pass = $_POST['passwordlogin'];
}
if (isset($_POST['email'])) {
    $email_register = $_POST['email'];
}
$_SESSION['temp'] = $_POST['email'];
?>

<div class="fb-header">
    <div id="img1" class="fb-header">
        <img src="img/facebook.png" />
    </div>
    <?php

    if ((empty($user_login) or empty($user_pass))) {
        include "src/form_login.php";
    }

    ?>
</div>

<div class="fb-body">
    <?php

    $sErrors = '';
    if (isset($_POST['submit2'])) {
        $sFname = escape($_POST['fname']);
        $sLname = escape($_POST['lname']);
        $sEmail = escape($_POST['email']);
        $sReEmail = escape($_POST['reemail']);
        $sPass = escape($_POST['password']);
        $sBirth = escape($_POST['birth']);
        if ($_SERVER['REQUEST_METHOD'] == "POST") {
            $iGender = (int)escape($_POST['sex']);
        }
        if (strlen($sFname) >= 1 and strlen($sFname) <= 20) {
            if (strlen($sLname) >= 1 and strlen($sLname) <= 10) {
                if (strlen($sEmail) >= 1 and strlen($sEmail) <= 55) {
                    if (!preg_replace('/^[a-zA-Z0-9\.\-]+\@[a-zA-Z0-9\-]+\.[a-zA-Z0-9\.\-]+$/', '', $sEmail)) {
                        if ($sEmail == $sReEmail) {
                            if (!preg_replace('/^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{6,15}$/', '', $sPass)) {
                                if (!preg_match("/[0-9]{2}\/[0-9]{2}\/[0-9]{4}/", $sBirth)) {

                                    $_SESSION['namelogin'] = $sEmail;
                                    $_SESSION['passwordlogin'] = $sPass;

                                    echo "<p align = 'center'> <b> Registration complete" . "<br>";
                                    echo "Sign in above" . "<br>";
                                    echo "Click <a href='Assignment3.php'> here </a> to HomePage </p>";
                                    exit;
                                } else {
                                    $sErrors = 'Birthday is wrong format';
                                }
                            } else {
                                $sErrors = 'Passwords are wrong format';
                            }
                        } else {
                            $sErrors = 'Email are not the same';
                        }
                    } else {
                        $sErrors = 'Email is wrong format';
                    }
                } else {
                    $sErrors = 'Address email is too long';
                }
            } else {
                $sErrors = 'Last Name is too long or empty';
            }
        } else {
            $sErrors = 'Fisrt Name is too long or empty';
        }

        // display step 2
        $aParams = array(
            '{errors}' => $sErrors,
            '{fname}' => $sFname,
            '{lname}' => $sLname,
            '{email}' => $sEmail,
            '{reemail}' => $sReEmail,
            '{pass}' => $sPass,
            '{sex}' => $iGender
        );
        echo strtr(file_get_contents('src/error.php'), $aParams);
        exit;
    }
    // draw registration page
    if ((empty($user_login) or empty($user_pass))) {
        echo strtr(file_get_contents('src/form_register.php'), array());
    } elseif (isset($_SESSION['namelogin']) and isset($_SESSION['passwordlogin'])) {
        if ($user_login == $_SESSION['namelogin'] and $user_pass == $_SESSION['passwordlogin']) {
            echo "<p align = 'center'> <b> Welcome newbie" . "<br>";
            echo "Click <a href='Assignment3.php'> here </a> to HomePage </p>";
        }
        else{
            echo "<p align = 'center'> <b> Email or Password is wrong <br> Please Log in again <br>";
            echo "Click <a href='Assignment3.php'> here </a> to HomePage </p>";
        }
    } else {
        echo " <h3 align = 'center'> Your account is not exists <br> Comeback HomePage to Create New Account </h3>";
        echo "<p align = 'center'>Click <a href='Assignment3.php'> here </a> to HomePage </p>";
    }
    function escape($s)
    {
        return strip_tags($s);
    }
    ?>
</div>

<?php
include "src/footer.php";
?>