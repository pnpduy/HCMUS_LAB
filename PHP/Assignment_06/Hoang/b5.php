<!DOCTYPE html>
<html>

<head>
    <link href="b5.css" rel="stylesheet" type="text/css" />
    <script>
        $(document).ready(function() {
            $("myInput").on("keyup", function() {
                var value = $(this).val().toLowerCase();
                $("#myTable tr").filter(function() {
                    $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                });
            });
        });
    </script>
</head>

<body>
    <?php
    $Type = $_GET['ConnectType'];
    if (strcmp($Type, 'ConnectToMySQL') == 0) {
        $servername = "127.0.0.1";
        $username = "root";
        $password = "";
        $dbname = "accountinfo";

        $conn = new mysqli($servername, $username, $password, $dbname);

        if ($conn->connect_error) {
            echo "Connection to MySQL could not be established. <br />";
            die("Connection failed: " . $conn->connect_error);
        } else {
            echo "Connection to MySQL successfully.<br />";
        }
    }

    $sql = "SELECT FirstName, LastName, Email, ID FROM account";
    $result = $conn->query($sql);

    echo "<table>
            <thead>
            <tr>
            <th>ID</th>
            <th>Firstname</th>
            <th>Lastname</th>
            <th>Email</th>
            </tr>
            </thead>
            <tbody id='myTable'>";
    while ($row = $result->fetch_assoc()) {
        echo "<tr>";
        echo "<td>" . $row['ID'] . "</td>";
        echo "<td>" . $row['FirstName'] . "</td>";
        echo "<td>" . $row['LastName'] . "</td>";
        echo "<td>" . $row['Email'] . "</td>";
        echo "</tr>";
    }
    echo "</tbody></table>";
    mysqli_close($conn);
    ?>
</body>

</html>