function solve(input){
    input.sort((a,b)=>a-b);
    let result = [];
    let index = 0;
    while(result.length<input.length){
        result.push(input[index]);
        if(index!==input.length-1-index){
            result.push(input[input.length-1-index]);
        }
       
        index++;
    }
    return result;
}
let res =  solve([1, 65, 3, 52, 48, 63, 31, -3, 18,
    ]);
console.log(res);