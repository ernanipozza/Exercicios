function clicou04(){
    let nome = prompt("Por favor, informe seu nome:");
    if (nome == " " || nome == "" || nome == null){
        alert("Informe um nome válido!")
    } else {
        alert("Olá " + nome + "!! Seja bem vindo/a, mas não se demore muito!")
    }
}