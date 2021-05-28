function solve(input){
    let result = [];
    for(let row = 0;row<input.length;row++){
        let sum = 0;
        for(let col = 0;col<input[row].length;col++){
            sum+=input[row][col];

        }
        result.push(sum);
    }
    let size = input[0].length;
    for(let col = 0;col<size;col++){
        let sum =0;
        for(let row =0;row<input.length;row++){
            sum+=input[row][col];
            

        }
        result.push(sum);
    }
    let isMagical = true;
    for(let i = 0;i<result.length;i++){
        for(let j =0;j<result.length;j++){
            if(result[i]!==result[j]){
                isMagical = false;
            }
        }

    }
    console.log(isMagical);
    

}
solve([[4, 5, 6],
    [6, 5, 4],
    [5, 5, 5]]);