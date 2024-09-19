<?php
require_once("DBconnect.php");
$db_handle = new DBconnect();
//check if form is submitted
if (isset($_POST['submit']))
{
	if(isset($_FILES['file1'])){
	$filename = $_FILES['file1']['name'];
	if($_FILES['file1']['error']>0){
		header("Location: index.php?st=fileerror");
	}
	else{
		//upload file
		if($filename != '')
		{
			$ext = pathinfo($filename, PATHINFO_EXTENSION);
			$allowed = ['pdf', 'txt', 'doc', 'docx', 'png', 'jpg', 'jpeg',  'gif'];
    
			//check if file type is valid
			if (in_array($ext, $allowed))
			{
			// get last record id
			$sql = 'select max(id) as id from tbl_files';
			$result = $db_handle->execute($sql);
			if ($db_handle->numRows($sql)> 0)
			{
			$row = mysqli_fetch_array($result);
			$filename = ($row['id']+1) . '-' . $filename;
			}
			else
			$filename = '1' . '-' . $filename;

			//set target directory
			$path = 'uploads/';
                
			$created = @date('Y-m-d H:i:s');
			move_uploaded_file($_FILES['file1']['tmp_name'],($path . $filename));
            
			// insert file details into database
			$sql = "INSERT INTO tbl_files(filename, created) VALUES('$filename', '$created')";
			$db_handle->execute($sql);
			header("Location: index.php?st=success");
			}
			else
			{
				header("Location: index.php?st=error");
			}
		}
		else
			header("Location: index.php");
		}
	}
}
?>