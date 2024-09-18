// Caixa de diálogo para o usuário confirmar: confirm("OK")
const b = document.querySelector("button")
b.addEventListener('click', ()=>{
    var w = window.open()
})
// Código para criar uma string apartir de uma seleção e ao clicar no link redireciona ao wikipédia 
const link = document.querySelector("a")
    link.addEventListener('click', ()=>{
        var q
        if (window.getSelection) q = window.getSelection().toString()
        else if (document.selection) q = document.selection.createRange().text
        void window.open('http://pt.wikipedia.org/wiki/' + q)
    })
 

//O método w.open() abre uma nova janela no navegador