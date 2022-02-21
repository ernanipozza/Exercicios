function clicou01(){
    let inputUsuario = document.getElementById("dataNascimento").value;
    let dataNascimento = new Date(inputUsuario);
    let diferenca = Date.now() - dataNascimento.getTime();
    let idadeDiferenca = new Date(diferenca);
    let ano = idadeDiferenca.getUTCFullYear();
    let idade = Math.abs(ano - 1970);
     
    return document.getElementById("resultado").innerHTML = "Você tem " + idade + " anos de idade. Tá jovem ainda, muita vida pela frente!"
}
