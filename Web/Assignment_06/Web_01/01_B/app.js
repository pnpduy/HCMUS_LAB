$(function() {
    $("button").click(function() {
        var radiusNr = $('.Radius').val();
        var a = Math.round(radiusNr*radiusNr*Math.PI);
        $('.Area').val(a);
        var b = Math.round(2*radiusNr*Math.PI);
        $('.Perimeter').val(b);
    })
})