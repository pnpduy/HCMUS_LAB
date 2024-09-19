function tinhTong() {
  var bankinh = document.getElementById("bankinh").value;

  var chuvi = bankinh * 2 * 3.14;
  var dientich = bankinh * bankinh * 3.14;

  document.getElementById("chuvi").value = chuvi;
  document.getElementById("dientich").value = dientich;

  console.log(chuvi);
  console.log(dientich);
}
