<?php
//connect mysql database
class DBconnect{
	private $host = "127.0.0.1";
	private $user = "root";
	private $password = "";
	private $database = "demo1";
	private $conn;

	function __construct() {
		$this->conn = $this->connectDB();
		if(!empty($this->conn)) {
		    $this->selectDB();
		}
	}
	
	function connectDB() {
		$conn = mysqli_connect($this->host,$this->user,$this->password,$this->database);
		return $conn;
	}
	
	function numRows($query) {
	    $result  = mysqli_query($this->conn, $query);
		$rowcount = mysqli_num_rows($result);
		return $rowcount;	
	}
	
	function selectDB() {
	    mysqli_select_db($this->conn, $this->database);
	}

	function execute($query) {
	    $result  = mysqli_query($this->conn, $query);
	    return $result;
	}
}
?>