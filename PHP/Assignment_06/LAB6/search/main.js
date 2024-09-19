fetch("infor.json")
  .then(function (response) {
    return response.json();
  })
  .then(function (data) {
    console.log(data);

    var table = document.getElementById("my-table");
    for (var i = 0; i < data.length; i++) {
      var row = `<tr>
        <td>${data[i].ID}</td>
        <td>${data[i].firstname}</td>
        <td>${data[i].lastname}</td>
        <td>${data[i].email}</td>`;

      table.innerHTML += row;
    }
  })
  .catch(function (err) {
    console.log(err);
  });

function FilterkeyWord() {
  // Declare variables

  var inputSearchId = document.getElementById("search_id");
  var inputSearchFirstName = document.getElementById("search_firstname");
  var inputSearchLastName = document.getElementById("search_lastname");
  var inputSearchEmail = document.getElementById("search_email");
  var filter = inputSearchId.value.toLowerCase();
  var filter1 = inputSearchFirstName.value.toLowerCase();
  var filter2 = inputSearchLastName.value.toLowerCase();
  var filter3 = inputSearchEmail.value.toLowerCase();
  var table = document.getElementById("table");
  var tr = table.getElementsByTagName("tr");

  // Loop through all table rows, and hide those who don't match the search query
  for (i = 0; i < tr.length; i++) {
    // change index to change your column search
    td = tr[i].getElementsByTagName("td")[0];
    td1 = tr[i].getElementsByTagName("td")[1];
    td2 = tr[i].getElementsByTagName("td")[2];
    td3 = tr[i].getElementsByTagName("td")[3];

    if (td && td1 && td2 && td3) {
      if (
        td.innerHTML.toLowerCase().indexOf(filter) > -1 &&
        td1.innerHTML.toLowerCase().indexOf(filter1) > -1 &&
        td2.innerHTML.toLowerCase().indexOf(filter2) > -1 &&
        td3.innerHTML.toLowerCase().indexOf(filter3) > -1
      ) {
        tr[i].style.display = "";
      } else {
        tr[i].style.display = "none";
      }
    }
  }
}
