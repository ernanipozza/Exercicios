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