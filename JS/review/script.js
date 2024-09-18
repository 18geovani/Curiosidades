const cadastrar = document.querySelector("button");

cadastrar.addEventListener('click', () => {
    let perfil = document.querySelector("textarea")
    let nome = document.querySelector('input[type ="text"]')
    let telefone = document.querySelector('input[type ="tel"]')
    let email = document.querySelector('input[type ="email"]')
    let pass = document.querySelector('input[type ="password"]')
   
    let pessoa = {
        nome: nome.value,
        telefone: telefone.value,
        email: email.value,
        pass: pass.value
    }
    let cadastros = []
    let pessoaJSON = JSON.stringify(pessoa)
    cadastros.push(pessoaJSON)
    localStorage.setItem('Pessoa',cadastros)
    localStorage.getItem('Pessoa')

    perfil.textContent = pessoaJSON
})


