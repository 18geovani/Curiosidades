//_______________________________LocalStorage_________________________________
/*
var nome = localStorage.username
nome = localStorage["username"]
nome = prompt("Qual é o teu nome?")
localStorage.username = nome


//______________________________Armazenando email_________________________________

var email = localStorage.email
email = localStorage["email"]
email = prompt("Diz o seu email")
localStorage.email = email

//______________________________Armazenando número de telefone___________________________________

var number = localStorage.numero
number = localStorage["numero"]
number = prompt("Informe o seu numero")
localStorage.numero = number

//______________________________Armazenando data de nascimento____________________________________

var dataNasc = localStorage.nascimento
dataNasc = localStorage["nascimento"]
dataNasc = prompt("Sua data de nascimento")
localStorage.nascimento = dataNasc

*/
/*
var nome = prompt("Nome")
localStorage.setItem("nome",nome)
localStorage.getItem("nome")
//_____________________A Remover um item do armazenamento
const remover = document.querySelector("button")
remover.addEventListener('click', ()=>{
    localStorage.removeItem("nome")
})
*/
/*
var id = localStorage.id
id = localStorage["id"]
id = prompt("Id do produto")
localStorage.id = id
*/
var texto = prompt("Texto")
localStorage.setItem("Texto",texto)
localStorage.getItem("Texto")