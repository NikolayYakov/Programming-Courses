function solve(input,steps){
    let result = [];
    for(let i =0;i<input.length;i+=steps){
         result.push(input[i]);

    }
    return result;
}
solve(['5','20','31','4', '20'],2);