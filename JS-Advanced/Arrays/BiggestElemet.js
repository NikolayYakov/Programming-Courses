function solve(input){
    let biggest = Number.MIN_SAFE_INTEGER;
    for(let row=0;row<input.length;row++){
        for(col = 0 ;col<input[row].length;col++){
            if(input[row][col]>biggest){
                biggest=input[row][col];
            }

        }
    }
    console.log(biggest);
}
solve([[20, 50, 10],
    [8, 33, 145]]);