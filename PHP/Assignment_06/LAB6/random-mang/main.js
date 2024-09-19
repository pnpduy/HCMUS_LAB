// var a = 10;

// var b = [1, 2, 3, 4, 5, 7];

// a = b.length;

// console.log(a);

// var valueNumber = document.getElementById("nhap").onchange().value;

// console.log(valueNumber)

// $(function () {
//   var newArr = new Array();

//   $("button.pstt").click(function () {
//     // Random 1 to 20
//     for (i = 0; i < valueNumber; i++)
//       newArr = newArr + Math.floor(Math.random() * 20 + 1) + " ";
//     // var maxInNumbers = Math.max.apply(Math, newArr);
//     // var minInNumbers = Math.min.apply(Math, newArr);
//     $("#mang").val(newArr);

//     // $("#max").val(maxInNumbers);
//     // $("#min").val(minInNumbers);
//     console.log(newArr);
//   });
// });

function tinhTong() {
  var valueNumber = document.getElementById("nhap").value;

  var newArr = new Array();

  for (i = 0; i < valueNumber; i++) {
    newArr = newArr + Math.floor(Math.random() * 20 + 1) + " ";
  }

  var newArr1 = newArr.split(" ");
  newArr1.join(" ");
  console.log(newArr1);

  let sum = 0;
  newArr1.forEach(function (value) {
    sum += Number(value);
  });

  console.log(sum);
  var min = Math.min(...newArr1);
  var max = Math.max(...newArr1);

  console.log(min);
  console.log(max);

  document.getElementById("mang").value = newArr;
  document.getElementById("min").value = min;
  document.getElementById("max").value = max;
  document.getElementById("tongmang").value = sum;

  console.log(valueNumber);
}
