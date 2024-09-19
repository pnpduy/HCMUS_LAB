<?php
// set error reporting level
if (version_compare(phpversion(), '5.3.0', '>=') == 1) // kiem tra phien bang php co lon hon hoac bang 1 hay ko?
    error_reporting(E_ALL & ~E_NOTICE & ~E_DEPRECATED);
// hang error_reporting la de thiet lap level cua loi do tai runtime
// E_ALL la hien thi tat cac error va warning, ngoai tru E_STRICT
// E_NOTICE dung trong script tim thay loi
// E_DEPRECATED tranh loi khi su trung ham parse_str()

else
    error_reporting(E_ALL & ~E_NOTICE);

$sCode = ''; // tao bien code de xac thuc dang ky tai khoan
session_start();
// kiem tra xem nut Register1 va Register2 da duoc click hay chua?
if (isset($_POST['submit0']) or isset($_POST['submits2'])) {

    //luu login, pass, cpass, email, gender vao form HTML va gan vao cac bien gia tri
    $sLogin = escape($_POST['login']);
    $sPass = escape($_POST['pass']);
    $sCPass = escape($_POST['cpass']);
    $sEmail = escape($_POST['email']);
    $iGender = (int)$_POST['gender'];

    $sErrors = ''; // tao bien bao loi
    // kiem tra login co du ky tu tu 1 -> 25 hay khong?
    if (strlen($sLogin) >= 1 and strlen($sLogin) <= 25) {
        // kiem tra pass co du ky tu tu 1 -> 25 hay khong?
        if (strlen($sPass) >= 1 and strlen($sPass) <= 25) {
            // kiem tra email co du ky tu tu 1 -> 55 hay khong?
            if (strlen($sEmail) >= 1 and strlen($sEmail) <= 55) {
                // kiem tra password co dung dinh dang hay khong? 
                // bao gom it nhat 1 chu hoa, 1 chu thuong, 1 chu so va co so luong chu cai tu 6 -> 15
                if (!preg_replace('/^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{6,15}$/', '', $sPass)) {
                    // kiem tra email da nhap dung so voi dong o tren hay chua
                    if ($sPass == $sCPass) {
                        // kiem tra email co dung dinh dang hay khong?
                        if (!preg_replace('/^[a-zA-Z0-9\.\-]+\@[a-zA-Z0-9\-]+\.[a-zA-Z0-9\.\-]+$/', '', $sEmail)) {
                            // kiem tra gioi tinh la Nam hay Nu?
                            // Nam la 1 va Nu la 0
                            if ($iGender == '1' xor $iGender == '0') {
                                // kiem tra nut Register2 da dc nhan hay chua? (nut Register1 da dc click)
                                if (isset($_POST['submits2'])) {
                                    // luu vcode vao form HTML va gan vao bien gia tri
                                    $sVcode = escape($_POST['vcode']);
                                    // kiem tra valdiation_code da duoc khoi tao chua?
                                    if (!isset($_SESSION['valdiation_code'])) {
                                        // Here you can send him some verification code (by email or any another ways)

                                        // neu chua duoc khoi tao valdiation_code thi random so vao sCode
                                        $sCode = uniqid(rand(), true);
                                        // md5() la ma hoa thong tin nham bao mat, an toan thong tin
                                        // gan thong tin ma hoa md5 vao session valdiation_code
                                        $_SESSION['valdiation_code'] = md5($sCode);
                                        // neu da khoi tao session valdiation_code 
                                        //thi kiem tra md5 va session valdiation_code co giong nhau khong?
                                    } elseif (md5($sVcode) == $_SESSION['valdiation_code']) {
                                        // Here you can add him to database
                                        // mysql_query('INSERT INTO ....

                                        // display step 3 (final step)

                                        //neu giong thi chuyen sang trang dang ky thanh cong
                                        echo strtr(file_get_contents('templates/step3.html'), array());
                                        exit;
                                    } else { // sai o dieu kien nao thi luu vao bien sErrors
                                        $sErrors = 'Verification code is wrong';
                                    }
                                }
                            } else {
                                $sErrors = 'Gender is wrong';
                            }
                        } else {
                            $sErrors = 'Email is wrong';
                        }
                    } else {
                        $sErrors = 'Passwords are not the same';
                    }
                } else {
                    $sErrors = 'Passwords are wrong format';
                }
            } else {
                $sErrors = 'Address email is too long';
            }
        } else {
            $sErrors = 'Password is too long';
        }
    } else {
        $sErrors = 'Login is too long';
    }

    //display step 2
    $aParams = array(
        // luu cac gia tri cua the html vao cac bien gia tri vao mang array
        '{errors}' => $sErrors,
        '{login}' => $sLogin,
        '{pass}' => $sPass,
        '{cpass}' => $sCPass,
        '{gender}' => $iGender,
        '{email}' => $sEmail,
        '{vcode}' => $sCode
    );
    // chuyen den trang xac thuc ma md5, voi cac bien da duoc luu
    // bao loi Error khi 1 trong nhung dieu kien if else sai
    echo strtr(file_get_contents('templates/step2.html'), $aParams);
    exit;
}

// unset validation code if exists
//giai phong validation code khi thoat khoi trang web
unset($_SESSION['valdiation_code']);

// draw registration page
// chuyen den trang facebook chinh
echo strtr(file_get_contents('templates/main_page.html'), array());

// extra useful function to make POST variables more safe
function escape($s)
{
    //return mysql_real_escape_string(strip_tags($s)); // uncomment in when you will use connection with database
    return strip_tags($s);
}
