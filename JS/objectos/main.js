/*
// ____________UM OBJECTO PESSOA_____________________
let pessoa = {nome: 'Geovani', 
    idade: 19, 
    altura: 161, 
    crescer(a = 0){
        console.log("Cresceu")
        this.altura += a 
    }}

    .crescer(2)
console.log(`${pessoa.nome} tem agora ${pessoa.altura} cm`)
*/


//_______________________String:::::::::::::::::::::::::::::::::::
/*

let vet = []
vet = "Acho que eu disse primeiro e último".toLowerCase()

let palavra = new String(vet)

console.log(palavra.split(" ")) //divide a string

let vogais = []
for(let i in palavra){
    if(palavra[i] === 'a' || palavra[i] === 'e' || palavra[i] === 'i' || palavra[i] === 'o' || palavra[i] === 'u')
    {
        vogais[i] = palavra[i]
    }     
} 
console.log(vogais.join(" ")) //add espaço entre 
*/


//___________________________________Cadastrando_______________________________
let pessoa1 = {
    nome: 'Geovani',
    idade: 19,
    numero: '933904255'
    }
let pessoa2 = {
    nome: 'Arlindo',
    idade: 18,
    numero: '956372625'
}

let perfil = document.querySelector("textarea")

const btn1 = document.querySelector(".criar")
    btn1.addEventListener('click', ()=>{
        perfil.style.textAlign = "left"
        perfil.textContent = `1- Pessoa \nNome: ${pessoa1.nome} \nIdade: ${pessoa1.idade} \nNúmero: ${pessoa1.numero} \n2-Pessoa \nNome: ${pessoa2.nome} \nIdade: ${pessoa2.idade} \nNúmero: ${pessoa2.numero}` 
    })

    const btn2 = document.querySelector(".apagar")
    btn2.addEventListener('click', ()=>{
        
        perfil.textContent = ""
    })

    function Guardar(){
        
        if(perfil.textContent == ""){
            alert("Campo de perfil vazio")
            return false
           }else{
            return true
           }
    }
const btn3 = document.querySelector(".guardar")
    btn3.addEventListener('click',()=>{
    if(Guardar()== true){
        //perfilrimeira pessoa
        localStorage.setItem('nome1',pessoa1.nome)
        localStorage.getItem('nome1')

        localStorage.setItem('idade1',pessoa1.idade)
        localStorage.getItem('idade1')

        localStorage.setItem('num1',pessoa1.numero)
        localStorage.getItem('num1')

        //Segunda pessoa
        localStorage.setItem('nome2',pessoa2.nome)
        localStorage.getItem('nome2')

        localStorage.setItem('idade2',pessoa2.idade)
        localStorage.getItem('idade2')
        
        localStorage.setItem('num2',pessoa2.numero)
        localStorage.getItem('num2')
    }
    })

const btn4 = document.querySelector(".remover")
    btn4.addEventListener('click', ()=>{
        localStorage.clear()    
    })
