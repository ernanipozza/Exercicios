class Retangulo{
    largura
    altura
    constructor(largura, altura){
        this.largura = largura
        this.altura = altura
    }

    calcularArea(){
        return this.largura * this.altura
    }
}

const arrayRetangulos = []

arrayRetangulos.push(new Retangulo(5, 8))
arrayRetangulos.push(new Retangulo(3, 9))
arrayRetangulos.push(new Retangulo(4, 7))
arrayRetangulos.push(new Retangulo(9, 14))
arrayRetangulos.push(new Retangulo(6, 2))
arrayRetangulos.push(new Retangulo(7, 8))
arrayRetangulos.push(new Retangulo(8, 11))
arrayRetangulos.push(new Retangulo(9, 7))


for(i = 0; i < arrayRetangulos.length; i++){
    console.log("A área do retângulo " + (i+1) + " é " + arrayRetangulos[i].calcularArea())
}