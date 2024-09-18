//let vet = [9,8,7,6,5,2,4]
//let soma = 0

//______________CÁLCULAR O FACTORIAL_______________
function fatorial(n){

    /* let fat = 1
    
    for(let i = n; i > 1; i--)
    {
        fat *= i 
    }
    return fat */

//__________FUNÇÃO REPERCURSIVA_________________

    if(n == 1){
        return 1
    }else{
        return n *fatorial(n-1)
    }
}
    console.log(fatorial(5))


//const res = 
//console.log(`O número é: ${res}`)


//____________FUNÇÃO PARA SOMAR OS PARES OU ÍMPARES______________
/*
for(let i in vet)
{
    saida = parImp(vet[i])
    console.log(`Na posição ${i} tem Par: ${saida}`)

    if(saida == true){
        soma += vet[i]
    }
}
    console.log(`A soma = ${soma}`)
function parImp(x){
    if(x%2==0){
        return true
    }else{
        return false
    }
}
*/
