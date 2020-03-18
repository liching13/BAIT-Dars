/*document.getElementById('btnSubmit').addEventListener("click",function(){
    let fName:string = (<HTMLInputElement>document.getElementById("fName")).value;
    let lName:string = (<HTMLInputElement>document.getElementById("lName")).value;
    ProcessData(fName, lName);
});

function ProcessData(fname:string, lname:string):void{
    let message:string = 'Congratulation!<br>Account ' +fname+ ' ' +lname+ ' has been created.';
    document.getElementById('txtArea').innerHTML = message;

    (<HTMLInputElement>document.getElementById("fName")).value = '';
    (<HTMLInputElement>document.getElementById("lName")).value = '';
}*/
document.getElementById('btnSubmit').addEventListener("click", ProcessData);
function ProcessData() {
    var fName = document.getElementById("fName").value;
    var lName = document.getElementById("lName").value;
    var fNum = parseInt(document.getElementById("fNum").value);
    var sNum = parseInt(document.getElementById("sNum").value);
    var message = '';
    if (isNaN(fNum) == true) {
        fNum = 0;
    }
    if (isNaN(sNum) == true) {
        sNum = 0;
    }
    if (fName.length == 0 || lName.length == 0) {
        message = "Please enter your Full Name!";
    }
    else {
        message = 'Congratulation!<br>Account ' + fName + ' ' + lName + ' has been created.';
        message += "<br>" + fNum.toString() + " + " + sNum.toString() + " = " + (fNum + sNum).toString();
    }
    document.getElementById('txtArea').innerHTML = message;
    document.getElementById("fName").value = '';
    document.getElementById("lName").value = '';
    document.getElementById("fNum").value = '';
    document.getElementById("sNum").value = '';
}
