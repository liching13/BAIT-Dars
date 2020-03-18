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

document.getElementById('btnSubmit').addEventListener("click",ProcessData);

function ProcessData(){
    let fName:string = (<HTMLInputElement>document.getElementById("fName")).value;
    let lName:string = (<HTMLInputElement>document.getElementById("lName")).value;
    let message:string = 'Congratulation!<br>Account ' +fName+ ' ' +lName+ ' has been created.';
    document.getElementById('txtArea').innerHTML = message;

    (<HTMLInputElement>document.getElementById("fName")).value = '';
    (<HTMLInputElement>document.getElementById("lName")).value = '';
}