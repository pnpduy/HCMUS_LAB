<!DOCTYPE html>
<html lang="en">

<head>
    <title>Web_2</title>
    <style>
        .error {
            color: red;
        }
    </style>
</head>

<body>
    <h2>PHP</h2>
    <p><span class="error">* required field.</span></p>
    <form method="post" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>">
        Name: <input type="text" name="name"></input>
        <span class="error">* <?php echo $nameErr; ?> </span>
        <br><br>

        E-mail: <input type="email" name="email">
        <span class="error">* <?php echo $emailErr; ?></span>
        <br><br>

        Website: <input type="text" name="website">
        <span class="error">* <?php echo $emailErr; ?></span>
        <br><br>

        comment: <textarea name="comment" cols="40" rows="5"></textarea>
        <br><br>

        General:
        <input type="radio" name="gender" value="female">Female
        <input type="radio" name="gender" value="male">Male
        <span class="error">* <?php echo $genderErr; ?></span>
        <br><br>

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