document.getElementById("btnSubmit").addEventListener("click", function () {
    var words = document.getElementById("wPlay").value;
    document.getElementById("result").innerHTML = PigLatin(words);
    document.getElementById("wPlay").value = "";
});
function PigLatin(word) {
    var wPlay = word.split(" ").filter(function (i) { return i; });
    var rWord = "";
    for (var i = 0; i < wPlay.length; i++) {
        rWord += wPlay[i].slice(1) + wPlay[i].slice(0, -wPlay[i].length + 1) + "ay ";
    }
    return rWord;
}
