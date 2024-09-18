// Seleciona o campo de pesquisa
let campoPesquisa = document.querySelector(".n-input")
// Seleciona todas as divs com classe "p"
let divs = document.querySelectorAll('.p')

// Adiciona um evento de input ao campo de pesquisa
campoPesquisa.addEventListener('input', function() {
    // Obtém o valor digitado pelo usuário
    let termoPesquisa = campoPesquisa.value.toLowerCase()

    // Percorre todas as divs
    divs.forEach(function(mostrar) {
        // Obtém o texto do título dentro da div
        let titulo = mostrar.querySelector('h3').textContent.toLowerCase()

        // Verifica se o termo de pesquisa está presente no título da div
        if (titulo.includes(termoPesquisa)) {
            // Se houver correspondência, mostra a div
            mostrar.style.display = 'block'
        } else {
            // Se não houver correspondência, oculta a div
            mostrar.style.display = 'none'
        }
    })
})