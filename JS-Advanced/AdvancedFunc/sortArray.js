function solve(input,arg){
    if(arg=='asc'){
        input.sort((a,b)=>a-b);
    }else if(arg=='desc'){
        input.sort((a,b)=>b-a);
    } 
    return input;
}

console.log(solve([14, 7, 17, 6, 8], 'asc'));