var botaoEnviar = document.querySelector("#botaoEnviar");
var campo = document.querySelector("#campo");
var lista = document.querySelector("#lista");
var itensDaLista = document.querySelector("#itensDaLista");
var itens = [];


botaoEnviar.addEventListener("click", function(){
    if(itens.includes(campo.value)){
        alert("O item informado já está na lista.")
    } else if(campo.value.length == 0) {
        alert("Nenhum item foi informado.")
    } else {
        itensDaLista.innerHTML += `<option value="${campo.value}" class="${campo.value}"> ${campo.value} </option>`
        lista.innerHTML += `<li id="${campo.value}" class="${campo.value}"> ${campo.value} <button id="botaoDelete" class="${campo.value}">DEL</button></li>`
        itens.push(" " + campo.value);
        campo.value = ""

        
        

    }
})

lista.addEventListener("click", function(e) {
    if(e.target.id === "botaoDelete") {
        lista.removeChild(e.target.parentElement)
        let classeDeletada = document.querySelector("." + e.target.className)
        console.log(e.target.className);
        itensDaLista.removeChild(classeDeletada)
    } 

})

function salvarLista(){
    localStorage.setItem("Produto", itens);
    console.log("salvei")
}

function recuperarLista(){
    if(localStorage.getItem("Produto") === null){
        document.getElementById("resultado").innerHTML = "Não há nenhum item previamente salvo."    
    } else {
        document.getElementById("resultado").innerHTML = localStorage.getItem("Produto");
    }
}
