<!DOCTYPE html>
<html lang="en">

<head>
	<meta charset="UTF-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>Document</title>

	<style>
		body {
			background-color: #262626;
			color: rgb(242, 242, 242);
		}

		table,
		td,
		th {
			table-layout: fixed;
			width: 300px;
			border-collapse: collapse;
			border: 3px solid black;
			text-align: center;
		}

		#stt,
		#stt_max,
		#stt_min {
			width: 20px;
			text-align: center;
		}

		#name,
		#name_max,
		#name_min {
			width: 190px;
		}

		#birth,
		#birth_max,
		#birth_min {
			width: 80px;
			text-align: center;
		}

		#avgmark,
		#avgmark_max,
		#avgmark_min {
			width: 28px;
			text-align: center;
		}

		#finddata {
			display: inline-block;
		}

		#avgmark_max,
		#stt_max,
		#name_max,
		#birth_max {
			background-color: green;

		}

		#avgmark_min,
		#stt_min,
		#name_min,
		#birth_min {
			background-color: red;
		}
	</style>
</head>

<body>
	<?php error_reporting(E_ALL ^ E_NOTICE); ?>

	<?php
	$path = "C:\\xampp\\htdocs\\PHP\\Lab_01\\StudentData.txt";
	$myfile = fopen($path, "r") or die("Can't open file!");
	fseek($myfile, 0);
	if (!empty($_GET['Id'])) {
		$user_id = $_GET['Id'];

		$check = 0;
		while (!feof($myfile)) {
			$keyword = fgets($myfile);
			$tach = explode("|", $keyword);

			if ($user_id == $tach[0]) {
				echo "<h3> Search Found</h3>";
				$check = 1;

				echo "<table>
				<tr>";
				foreach ($tach as $datas) {

					echo "<td>$datas</td>";
				}
				echo "</tr>
				</table>";
			}
		}
		if ($check == 0) {
			echo "<h3>Not Found</h3>";
		}
	}

	if (!empty($_GET['Name'])) {
		$user_id = $_GET['Name'];
		$check = 0;
		while (!feof($myfile)) {
			$keyword = fgets($myfile);
			$tach = explode("|", $keyword);

			if ($user_id == $tach[1]) {
				echo "<h3> Search Found</h3>";
				$check = 1;
				echo "<table>
				<tr>";
				foreach ($tach as $datas) {

					echo "<td>$datas</td>";
				}
				echo "</tr>
				</table>";
			}
		}
		if ($check == 0) {
			echo "<h3>Not Found</h3>";
		}
	}
	fclose($myfile);
	?>


	<!-- Đọc file này và hiển thị lên trang web thành dạng table (có đường kẻ bảng) -->
	<?php
	$path = "C:\\xampp\\htdocs\\PHP\\Lab_01\\StudentData.txt";
	$myfile = fopen($path, "r") or die("Can't open file!");

	$max = 5.0;
	$min = 5.0;
	while (!feof($myfile)) {
		$keyword = fgets($myfile);
		$tach = explode("|", $keyword);
		if ($max <= (float) $tach[3]) {
			$max = $tach[3];
		} else if ($min > (float) $tach[3]) {
			$min = $tach[3];
		}
	}
	

	fseek($myfile, 0);
	while (!feof($myfile)) {
		$keyword = fgets($myfile);
		$tach = explode("|", $keyword);

		echo "<table>
			<tr>";

		if ($max == $tach[3]) {
			echo "<td id='stt_max'>$tach[0]</td>
			<td id='name_max'>$tach[1]</td>
			<td id='birth_max'>$tach[2]</td>
			<td id='avgmark_max'>$tach[3]</td>";
		} else if ($min == $tach[3]) {
			echo "<td id='stt_min'>$tach[0]</td>
			<td id='name_min'>$tach[1]</td>
			<td id='birth_min'>$tach[2]</td>
			<td id='avgmark_min'>$tach[3]</td>";
		} else {
			echo "<td id='stt'>$tach[0]</td>
			<td id='name'>$tach[1]</td>
			<td id='birth'>$tach[2]</td>
			<td id='avgmark'>$tach[3]</td>";
		}
		echo "</tr>
	</table>";
	}
	?>

</body>

</html>