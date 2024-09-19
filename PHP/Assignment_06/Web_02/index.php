<!DOCTYPE html>
<html lang="en">

<head>
    <?php
    $nameErr = $emailErr = $genderErr = $websiteErr = "";
    $name = $email = $gender = $website = "";

    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        if (empty($_POST["name"])) {
            $nameErr = "Name is required";
            $result1 = "background-color: #FFE4C4";
        } else {
            $name = test_input($_POST["name"]);
        }

        if (empty($_POST["email"])) {
            $emailErr = "Email is required";
            $result2 = "background-color: 	#F4A460";
        } else {
            $email = test_input($_POST["email"]);
        }

        if (empty($_POST["website"])) {
            $websiteErr = "Website is required";
            $result3 = "background-color: #ADD8E6";
        } else {
            $website = test_input($_POST["website"]);
        }

        if (empty($_POST["comment"])) {
            $comment = "";
            $result4 = "background-color: #98FB98";
        } else {
            $comment = test_input($_POST["comment"]);
        }

        if (empty($_POST["gender"])) {
            $genderErr = "Gender is required";
            $result5 = "background-color: #BDB76B";
        } else {
            $gender = test_input($_POST["gender"]);
        }
    }
    function test_input($data)
    {
        $data = trim($data);
        $data = stripslashes($data);
        $data = htmlspecialchars($data);
        return $data;
    }
    ?>
    <title>Web_2</title>
    <style>
        .error {
            color: red;
        }

        .name {
            width: 400px;
            border-radius: 10px;
        }

        .email {
            width: 400px;
            border-radius: 10px;
        }

        .website {
            width: 400px;
            border-radius: 10px;
        }

        .comment {
            width: 400px;
            border-radius: 10px;
        }

        .general {
            width: 400px;
            border-radius: 10px;

        }
    </style>
</head>

<body>
    <h2>PHP</h2>
    <p><span class="error">* required field.</span></p>
    <form method="post" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>">

        <div class="name" style="<?php echo $result1 ?>">
            Name: <input type="text" name="name"></input>
            <span class="error">* <?php echo $nameErr; ?> </span>
            <br><br>
        </div>

        <div class="email" style="<?php echo $result2 ?>">
            E-mail: <input type="email" name="email">
            <span class="error">* <?php echo $emailErr; ?></span>
            <br><br>
        </div>

        <div class="website" style="<?php echo $result3 ?>">
            Website: <input type="text" name="website">
            <span class="error">* <?php echo $websiteErr; ?></span>
            <br><br>
        </div>

        <div class="comment" style="<?php echo $result4 ?>">
            comment: <textarea name="comment" cols="40" rows="5"></textarea>
            <br><br>
        </div>

        <div class="general" style="<?php echo $result5 ?>">
            General:
            <input type="radio" name="gender" value="female">Female
            <input type="radio" name="gender" value="male">Male
            <span class="error">* <?php echo $genderErr; ?></span>
            <br><br>
        </div>

        <input type="submit" name="submit" value="Submit">
    </form>

    <?php

    echo "<h2>Your Input:</h2>";
    echo "Name:" . $name;
    echo "<br>";
    echo "Email:" . $email;
    echo "<br>";
    echo "Website:" . $website;
    echo "<br>";
    echo "Comment:" . $comment;
    echo "<br>";
    echo "Gender:" . $gender;
    echo "<br>";
    ?>
</body>

</html>