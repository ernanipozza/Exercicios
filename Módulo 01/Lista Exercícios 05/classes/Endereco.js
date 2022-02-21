class Endereco{
    logradouro;
    numero;
    cidade;
    estado;
    pais;
    cep;

    constructor(logradouro, numero, cidade, estado, pais, cep){
        if (typeof logradouro !== "string" || typeof numero !== "string" || typeof cidade !== "string" || typeof estado !== "string" || typeof pais !== "string" || typeof cep !== "string") {
            throw "Endereço Inválido!"
        }

        if (!this.confereCep(cep)) {
            throw "CEP inválido"
        }

        this.logradouro = logradouro;
        this.numero = numero;
        this.cidade = cidade;
        this.estado = estado;
        this.pais = pais;
        this.cep = cep;
    }

    confereCep(cep){
        var tamanho = cep.length;
        if (tamanho !== 9 || cep[5] !== "-"){
            return false
        }
        for(var i = 0; i < tamanho; i++){
            if(i !== 5){
                if(cep[i] < "0" || cep[i] > "9"){
                    return false
                }
            }
        }
        return true
    }
}

var rua1 = new Endereco("Rua das Jiripocas", "25", "Angelina", "SC", "Brasil", "12345-678")
console.log(rua1);