function clicou02(id){
    let valor1 = Number(document.getElementById("valor1").value);
    let valor2 = Number(document.getElementById("valor2").value);
    
    switch(id){
        case "soma":
            document.getElementById("resultado").value = valor1 + valor2;
            break
        case "subtracao":
            document.getElementById("resultado").value = valor1 - valor2;
            break
        case "multiplicacao":
            document.getElementById("resultado").value = valor1 * valor2;
            break
        case "divisao":
            document.getElementById("resultado").value = valor1 / valor2;
            break
    }
}