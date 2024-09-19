$(function () {
  $("input").change(function () {
    var timer = $(this).val();
    console.log(timer);
    $("button").click(function () {
      var message;
      if (timer <= 12) {
        message = "Chào buổi sáng";
      } else if (timer <= 17) {
        message = "Chào buổi chiều";
      } else {
        message = "Chào buổi tối";
      }

      $("#message").append(message);
    });
  });
});
