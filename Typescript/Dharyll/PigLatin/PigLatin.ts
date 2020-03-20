document.getElementById("btnSubmit").addEventListener("click",function(){
        let words:string = (<HTMLInputElement>document.getElementById("wPlay")).value;
        document.getElementById("result").innerHTML = PigLatin(words);
        (<HTMLInputElement>document.getElementById("wPlay")).value = "";
});

function PigLatin(word:string):string{
    let wPlay: Array<string> = word.split(" ").filter(i=>i);
    let rWord: string = ""
    
    for (let i: number = 0; i < wPlay.length; i++)
    {
        rWord += wPlay[i].slice(1) + wPlay[i].slice(0,-wPlay[i].length+1) + "ay "
    }

    return rWord;
}