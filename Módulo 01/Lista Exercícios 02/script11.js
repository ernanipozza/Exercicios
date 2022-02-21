function clicou11(){
    const valorInicial = prompt("Informe um valor numérico para ser o início da P.A.:");
    const raiz = prompt("Informe um valor numérico para ser a raiz da P.A.:");
    let novoValor = Number(valorInicial) + Number(raiz);
    let array = [Number(valorInicial), novoValor];
    
    if(isNaN(valorInicial) || isNaN(raiz)){
        alert("Você digitou um valor não numérico em uma das opções. Se isso for muito difícil pra você, peça ajuda para o papai ou para a mamãe, humano.")
    } else {
        for(i = 0; i <= 7; i++){
            novoValor += Number(raiz);
            array.push(novoValor);
        }
        alert("Os " + array.length + " primeiros elementos da P.A. resultante são: " + [array])
    }
}