const form = document.querySelector("#form")
const inputNome = document.querySelector("#name")
const inputEmail = document.querySelector("#email")
const inputPass = document.querySelector("#password")
const mensagem = document.querySelector("#message")


form.addEventListener("keyup", function() {

     mensagem.textContent = inputNome.innerHTML
})

/*
const pessoas = [
    {nome: "Geovani", idade: 18, salario: 2000000},
    {nome: "Pazito", idade: 43, salario: 800000},
    {nome: "Uano", idade: 34, salario: 909770},
    {nome: "Mário", idade: 23, salario: 890000}
]
const idades = pessoas.map(dados => dados.idade) 
*/


