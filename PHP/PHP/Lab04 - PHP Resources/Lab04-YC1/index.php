<?php
include_once 'DBconnect.php';
// fetch files
$db_handle = new DBconnect();
$sql = "select filename from image_message";
$result = $db_handle->execute($sql);
?>

<!DOCTYPE html>
<html lang="en">

<head>
	<meta charset="UTF-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<link rel="stylesheet" href="css/style.css" type="text/css">
	<title>Upload Image And Post Message</title>
</head>

<body>
	<div class="content">
		<h1>Upload Image And Post Message</h1>
		<form id="uploadImgMess" action="index.php" method="post" enctype="multipart/form-data">
			<div id="selectImage">
				<label>Select Your Image</label><br />
				<input type="file" name="file" id="file" required />
			</div>

			<div id="selectMessage">
				<label>Select Your Message</label><br />
				<textarea name="txt_message" id="txt_message" cols="30" rows="10"></textarea>
			</div>

			<div id="btnSubmit">
				<input type="submit" name="upload" value="Upload" class="submit" />
			</div>
		</form>
	</div>

</body>

</html>