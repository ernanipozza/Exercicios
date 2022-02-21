const veraoInicio = new Date(2020,(12-1), 22);
const veraoFinal = new Date(2021, (03-1), 21);
const outonoInicio = new Date(2021, (03-1), 22);
const outonoFinal = new Date(2021, (06-1), 21);
const invernoInicio = new Date(2021, (06-1), 22);
const invernoFinal = new Date(2021, (09-1), 21);
const primaveraInicio = new Date(2021, (09-1), 22);
const primaveraFinal = new Date(2021, (12-1), 21);

let dataInformada = new Date();
console.log(dataInformada);

if(dataInformada > veraoInicio && dataInformada < veraoFinal){
    var imagem = document.createElement("img");
    imagem.src = "./images/verao.gif"
    var src = document.getElementById("imagemRecebida");
    src.appendChild(imagem);

    document.getElementById("textoEstacao").innerHTML = "Passa o inverno, chega o verão. O calor aquece minha emoção. Não pelo clima da estação. Mas pelo fogo dessa paixão!"
}

if(dataInformada > outonoInicio && dataInformada < outonoFinal){
    var imagem = document.createElement("img");
    imagem.src = "./images/outono.gif"
    var src = document.getElementById("imagemRecebida");
    src.appendChild(imagem);

    document.getElementById("textoEstacao").innerHTML = "O outono é sempre igual, as folhas caem no quinta... só não cai o meu amor, pois não tem jeito, é imortal!"
}

if(dataInformada > invernoInicio && dataInformada < invernoFinal){
    var imagem = document.createElement("img");
    imagem.src = "./images/inverno.gif"
    var src = document.getElementById("imagemRecebida");
    src.appendChild(imagem);

    document.getElementById("textoEstacao").innerHTML = "A noite cai, o frio desce, Mas aqui dentro predomina esse amor que me aquece. Protege da solidão!"
}

if(dataInformada > primaveraInicio && dataInformada < primaveraFinal){
    var imagem = document.createElement("img");
    imagem.src = "./images/primavera.gif"
    var src = document.getElementById("imagemRecebida");
    src.appendChild(imagem);

    document.getElementById("textoEstacao").innerHTML = "Na primavera, calmaria, tranquilidade, uma quimera. Queria sempre essa alegria, viver sonhando, quem me dera!"
}