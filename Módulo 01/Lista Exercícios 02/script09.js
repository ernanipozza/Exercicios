function clicou09(){
    let operacao = prompt("Informe o tipo de operação aritmética que deseja efetuar: soma(1), subtração(2), multiplicação(3), divisão(4)");
    if (isNaN(operacao) || operacao < 1 || operacao > 4){
        alert("Amigo, eu pedi pra você escolher uma das opções que eu mostrei. Não perca meu tempo, por favor.")
    } else {
        let valor1 = prompt("Informe um valor numérico:");
        let valor2 = prompt("Informe mais um valor numérico:");
        switch (operacao){
            case "1":
                alert("A soma dos valores informados é " + (Number(valor1) + Number(valor2)) + ".");
                break;
            case "2":
                alert("A subtração dos valores informados é " + (Number(valor1) - Number(valor2)) + ".");
                break;
            case "3":        
                alert("A multiplicação dos valores informados é " + (Number(valor1) * Number(valor2)) + ".");
                break;
            case "4":
                if(valor2 == "0"){
                    alert("TÁ MALUCO IRMÃO, DIVIDIR POR ZERO????")
                } else {
                alert("A divisão dos valores informados é " + (Number(valor1) / Number(valor2)) + ".");
                break;
                }
            default:
                console.log("Não tem como dar errado, confia.")
        }
    }
}