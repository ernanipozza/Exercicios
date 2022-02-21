function clicou01(){
    let paragrafo = document.getElementById("paragrafo01");
    let emoji = String.fromCodePoint(0x1F621);
    let emojify = document.createTextNode(emoji);
    paragrafo.appendChild(emojify);

}
