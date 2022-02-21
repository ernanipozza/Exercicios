function clicou08(){
    let anoNascimento = prompt("Por favor, informe o ano de seu nascimento:");
    if (anoNascimento == ""){
        alert("Informe um ano válido!")
    } else {
        let anoCorrente = prompt("Por favor, informe o ano atual:");
        if (anoCorrente == ""){
        alert("Informe um ano válido!")
        } 
        let idade = Number(anoCorrente) - Number(anoNascimento);
        if (idade < 0){
            alert("Tá maluco irmão, como é que você nasceu no futuro???")
        } else {
        alert("Se você ainda não fez aniversário, tem " + (idade - 1) + " anos de idade. Caso já tenha feito aniversário, tem " + idade + " anos de idade.");
        }
    }
}