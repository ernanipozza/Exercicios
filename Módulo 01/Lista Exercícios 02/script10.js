function clicou10(){
    let horario = new Date();

    let hora = horario.getHours();
    let minutos = horario.getMinutes();
    let horaCompleta = hora + ":" + minutos;

    if(hora == 0){
        alert("Em Brasília, 0" + horaCompleta + ". (imagine O Guarani, de Carlos Gomes, tocando ao fundo).");
    } else {
        alert("Em Brasília, " + horaCompleta + ". (imagine O Guarani, de Carlos Gomes, tocando ao fundo).");
    }
}