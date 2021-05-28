function solve(input){
    let result =  [];
    for(let i =1;i<input.length;i+=2){
        result.push(input[i]);
    }
    result = result.map(x=>x*2).reverse();
    console.log(result.join(' '));
}
solve([3, 0, 10, 4, 7, 3]);