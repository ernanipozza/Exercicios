function clicou03(){
  let valor = document.getElementById("valor").value;
  let par = Number(valor) %2 == 0;
  
  switch(par){
    case true:
      document.getElementById("resultado").value = "É par!";
      break
    case false:
      document.getElementById("resultado").value = "É impar!";
      break
  }
}