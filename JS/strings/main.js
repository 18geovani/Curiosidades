/*
let entrada = document.querySelector("#entrada")
entrada.addEventListener('input', ()=>{
    let saida = document.querySelector("#area")
    let escrito = entrada.value
    saida.textContent = escrito
})
*/






let palavras = []

palavras = "Minha vida em Javascript"
let strings = new String(palavras)
let regex = /vida/g
console.log(strings.replace(regex, " "))

