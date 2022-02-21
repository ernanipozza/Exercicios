function exibeHora() {
    let horario = new Date();
    let hora = horario.getHours();
    hora = ("0" + hora).slice(-2);
    let minutos = horario.getMinutes();
    minutos = ("0" + minutos).slice(-2);
    let horaCompleta = hora + ":" + minutos;
    document.getElementById("relogio").innerHTML = horaCompleta;
}

setInterval(exibeHora, 500)