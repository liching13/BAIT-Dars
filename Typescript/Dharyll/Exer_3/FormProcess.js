document.getElementById('btnSubmit').addEventListener("click", function () {
    var fName = document.getElementById("fName").value;
    var lName = document.getElementById("lName").value;
    ProcessData(fName, lName);
});
function ProcessData(fname, lname) {
    var message = 'Congratulation!<br>Account ' + fname + ' ' + lname + ' has been created.';
    document.getElementById('txtArea').innerHTML = message;
    document.getElementById("fName").value = '';
    document.getElementById("lName").value = '';
}
