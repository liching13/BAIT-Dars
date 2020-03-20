document.getElementById('btnSubmit').addEventListener('click', function () {
    var num = Number(document.getElementById('persistNum').value);
    Persistence(num);
    document.getElementById('persistNum').value = '';
});
function Persistence(num) {
    var equation = '';
    if (num >= 0) {
        var persistNum = num;
        var count = 0;
        while (persistNum.toString().length != 1) {
            var prod = 1;
            var number = persistNum.toString();
            for (var i = 0; i < number.length; i++) {
                prod = prod * Number(number.charAt(i));
                equation += number.charAt(i) + '&nbsp';
            }
            equation += '= ' + prod + "<br>";
            persistNum = prod;
            count++;
        }
        equation += 'The Total Number of Persistence is: ' + count;
        document.getElementById('result').innerHTML = equation;
    }
    else {
        equation += 'The number must be greater than 0';
        document.getElementById('result').innerHTML = equation;
    }
}
