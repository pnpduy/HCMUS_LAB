function check1(){
    var numBuy1 = document.frmtable.numBuy1.value;

    if(numBuy1 > 10){
        alert("Quá số lượng sản phẩm !");
    }
}
function check2(){
    var numBuy2 = document.frmtable.numBuy2.value;

    if(numBuy2 > 10){
        alert("Quá số lượng sản phẩm !");
    }
}
function check3(){
    var numBuy3 = document.frmtable.numBuy3.value;

    if(numBuy3 > 10){
        alert("Quá số lượng sản phẩm !");
    }
}

function OK(){
    var numBuy1 = document.frmtable.numBuy1.value;
    var numBuy2 = document.frmtable.numBuy2.value;
    var numBuy3 = document.frmtable.numBuy3.value;

    s = numBuy1*100 + numBuy2*50 + numBuy3*80;
    result = eval(s)

    document.frmtable.sumBuy.value = result;
}

function checkVAT(){
    var numBuy1 = document.frmtable.numBuy1.value;
    var numBuy2 = document.frmtable.numBuy2.value;
    var numBuy3 = document.frmtable.numBuy3.value;
    

    s = (numBuy1*100 + numBuy2*50 + numBuy3*80)*0.1 + (numBuy1*100 + numBuy2*50 + numBuy3*80);
    result = eval(s)

    document.frmtable.sumBuy.value = result;
}