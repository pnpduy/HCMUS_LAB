<?php
header("Content-Type: application/json; charset=UTF-8");
$obj = json_decode($_GET("search"), false);

$servername = "127.0.0.1";
$username = "root";
$password = "";
$dbname = "accountinfo";

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
    echo "Connection to MySQl could not be established. <br/>";
    die("Connection failed:" . $conn->connect_error);
} else {
    $querystr = "SELECT ID, FirstName, LastName, Email FROM" . $obj->table;
    $querystr = $querystr . " WHERE FirstName LIKE'" . $obj->FirstName . "'";
    $querystr = $querystr . " AND Email LIKE'" . $obj->Email . "'";
    
    $result = $conn->query($querystr);
    $outp = array();
    $outp = $result->fetch_all(MYSQLI_ASSOC);

    echo json_encode($outp);
}
