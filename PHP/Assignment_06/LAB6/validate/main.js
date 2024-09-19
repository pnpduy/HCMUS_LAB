function Validate() {
  var name = document.getElementById("ten").value;
  var email = document.getElementById("ymeo").value;
  var messageName = document.getElementById("messagename");
  var messageEmail = document.getElementById("messageemail");
  console.log(name);

  var bgn = document.getElementById("bgn");
  var bgemail = document.getElementById("bgemail");
  if (name == 0 || name == null) {
    messageName.innerText = "Name is required";
    messageName.style.color = "red";
    bgn.style.backgroundColor = "blue";

    console.log(name);
  } else {
    bgn.style.removeProperty("backgroundColor");
  }

  if (email == 0 || email == null) {
    messageEmail.innerText = "Email is required";
    messageEmail.style.color = "red";

    bgemail.style.backgroundColor = "blue";
  }
}
