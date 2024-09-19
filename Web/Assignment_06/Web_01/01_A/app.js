$(function() {
    $("input").change(function() {
        var timeHr = $('.Time').val();
    $("button").click(function(){
        var str;
        if (timeHr <= 12) {
            str = "Chào buổi sáng";
        }
        else{
            if (timeHr <= 17) {
                str = "Chào buồi chiều";
            }
            else{
                str = "Chào buổi tối";
            }
        }
        $(".HelloDiv").append(str);
        })
    }) 
})
