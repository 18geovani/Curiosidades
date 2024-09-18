let n = [2,5,8,7,4]
n.push(1,3,6)

let O = n.sort()
console.log(`Ord crescente: ${O}`)

console.log("\n")

for(let i in n){
    console.log(`O valor da posição ${i} é: ${n[i]}`)
}

console.log("\t")

let Od = O.reverse()
console.log(`Ord decrescente: ${Od}`)

console.log("\n")

for (let i in n)
{
    console.log(`O valor da posição: ${i} é: ${n[i]}`)
}

/*
_____________USANDO O FOR______________ 
for(let i = 0; i < n.length ; i++)
 {
    console.log(`O valor da posição: ${i} é: ${n[i]}`)
 }
  */

 /*
 let i = 0

_____________USANDO O WHILE____________

while(i<n.length){
    console.log(`O valor da posição: ${i} é: ${n[i]}`)
    i++
}
*/


