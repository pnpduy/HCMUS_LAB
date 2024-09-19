$(function(){
    var NumArr = "";
        $("button").click(function(){
            var numArr = $(".Number").val();
            var Max = 0;
            var Min = 20;
            var Num;
            for(i = 0; i < numArr; i++){
                Num = Math.floor(Math.random() * 20);
                NumArr = NumArr + Num + " ";
                    if (Num > Max)
                    Max = Num;
                    if (Num < Min)
                    Min = Num;
            }

            var EleNum = NumArr.split(' ');
            var Sum = 0;
            $.each(EleNum, function(index,value){
                Sum = Sum + Number(value);
            });


            $("#Array").val(NumArr);    
            $("#MAX").val(Max);    
            $("#MIN").val(Min);
            $("#SUM").val(Sum);    
        });
});