function clicou06() {
  let nome = prompt("Por favor, informe seu nome:");
  if (nome == "" || nome == null) {
    alert("Informe um nome válido!");
  } else {
    let sobrenome = prompt("Por favor, informe seu sobrenome:");
    if (sobrenome == "" || sobrenome == null) {
      alert("Informe um sobrenome válido!");
    }
    alert("Olá " + nome + " " + sobrenome + "!! Seja bem vindo/a, mas não se demore muito!"
    );
  }
}
