// var fname = document.getElementById("namebox");
// fname.addEventListener("input", () => {
// 	if (fname.validity.tooLong || fname.validity.tooShort || fname.validity.valueMissing) {
// 		fname.setCustomValidity("Name must be 2-8 characters.");
// 		fname.reportValidity();
// 	} else { fname.setCustomValidity(""); }
// });

var form = document.getElementById('form03'),
	firstName = document.getElementById('namebox'),
	errorMessage = document.getElementById('errorname');

function check(event) {
	event.preventDefault();
	if (firstName.value === '' || !firstName.value.length) {
		// console.log('here')
		errorMessage.innerText = 'This is an invalid name';
	} else {
		errorMessage.innerText = '';
	}
}

form.addEventListener('submit', check);


