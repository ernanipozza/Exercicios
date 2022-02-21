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


class Cliente{
    nome;
    cpf;
    endereco;
    numeroDoCelular;

    constructor(nome, cpf, endereco, numeroDoCelular){
        if (typeof nome !== "string" || typeof cpf !== "string" || !(endereco instanceof Endereco) || typeof numeroDoCelular !== "string") {
            throw "Parâmetro Inválido!"
        }

        this.nome = nome;
        this.cpf = cpf;
        this.endereco = endereco;
        this.numeroDoCelular = numeroDoCelular;
    }
}

var cliente1 = new Cliente("Jão", "000.000.000-00", rua1, "+5548999999999");
console.log(cliente1);

class Conta{
    numeroDaConta;
    saldo;
    cliente;

    constructor(numeroDaConta, saldo, cliente){
        if (typeof numeroDaConta !== "string" || typeof saldo !== "number" || !(cliente instanceof Cliente)) {
            throw "Parâmetro Inválido!"
        }

        this.numeroDaConta = numeroDaConta;
        this.saldo = saldo;
        this.cliente = cliente;
    }
}

var conta1 = new Conta("4500-1", 4500, cliente1);
console.log(conta1);