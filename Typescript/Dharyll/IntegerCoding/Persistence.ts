document.getElementById('btnSubmit').addEventListener('click', function(){
    let num: number = Number((<HTMLInputElement>document.getElementById('persistNum')).value);
    Persistence(num);
    (<HTMLInputElement>document.getElementById('persistNum')).value = '';
});

function Persistence(num: number):void{
    let equation:string = '';
    if(num >= 0) 
    {
        let persistNum: number = num;
        let count: number = 0;
   
        while(persistNum.toString().length != 1)
        {
            let prod: number = 1;
            let number: string = persistNum.toString();

            for(let i: number = 0; i < number.length; i++)
            {
                prod = prod *  Number(number.charAt(i));
                equation += number.charAt(i) + '&nbsp';
            }
            equation += '= ' + prod + "<br>";
            persistNum = prod;
            count++
        }
        equation += 'The Total Number of Persistence is: ' + count;
        document.getElementById('result').innerHTML = equation;
    }
    else
    {
        equation += 'The number must be greater than 0'
        document.getElementById('result').innerHTML = equation;
    }
}