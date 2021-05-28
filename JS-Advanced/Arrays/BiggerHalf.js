function solve(input){
    input.sort((a,b)=>a-b);
    let length = Math.floor(input.length/2)
    let resultArray = input.slice(length);
    return resultArray;


    
}
let result = solve([4, 7, 2, 5]);
console.log(result);