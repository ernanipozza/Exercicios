function checaCondicoes(){
  const valorInicial = document.getElementById("valorInicial").value;
  const raiz = document.getElementById("raiz").value;

  if(valorInicial.length == 0 || raiz.length == 0){
    alert("Preencha os campos corretamente.");
  }
}

function calculaPA(){
  checaCondicoes();
  const valorInicial = document.getElementById("valorInicial").value;
  const raiz = document.getElementById("raiz").value;
  let novoValor = Number(valorInicial) + Number(raiz);
  let array = [Number(valorInicial), novoValor];
  for(i = 0; i <= 7; i++){
    novoValor += Number(raiz);
    array.push(novoValor);
  }
  document.getElementById("resultado").innerHTML = array;
}

function calculaPG(){
  checaCondicoes();
  const valorInicial = document.getElementById("valorInicial").value;
  const raiz = document.getElementById("raiz").value;
  let novoValor = Number(valorInicial) * Number(raiz);
  let array = [Number(valorInicial), novoValor];
  for(i = 0; i <= 7; i++){
    novoValor *= Number(raiz);
    array.push(novoValor);
  }
  document.getElementById("resultado").innerHTML = array;
}
