function abrePaginaExercicio(id){
    window.open("./exercicio.html?id="+id+".js").focus();
}

var id = new URLSearchParams(location.search).get("id")

function imprimeExercicio() {
    title.innerHTML = `${id}`;
    tituloExercicio.innerHTML = `ABCDEF${id}`
    scriptExercicio.innerHTML = `<script src="exercicios/${id}"></script>`
}

imprimeExercicio(id)