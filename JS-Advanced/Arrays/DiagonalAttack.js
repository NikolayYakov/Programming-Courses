function solve(input){
    let mainSum = 0;
    let ortoSum = 0;
    let result = [[]];
    
    for(let row = 0;row<input.length;row++){
        let rowNumber = input[row].split(' ');
        for(let i = 0;i<rowNumber.length;i++){
            rowNumber[i] = Number(rowNumber[i]);
        }
        result[row] = rowNumber

    }
    let diaoganals = [];
    for(let i = 0;i<result.length;i++){
        mainSum+=result[i][i];
        ortoSum+=result[i][result.length-1-i];
        diaoganals.push(`${i} ${i}`);
        diaoganals.push(`${i} ${result.length-1-i}`);


    }
    if(mainSum===ortoSum){
        for(let row = 0;row<result.length;row++){
            for(let col = 0;col<result.length;col++){
                let cordinates = `${row} ${col}`;
                if(!diaoganals.includes(cordinates)){

                    result[row][col]=mainSum;
                }
                
            }
            
        }
    }
    for(let row = 0;row<result.length;row++){
        console.log(result[row].join(' '));
    }
    

}
solve(['5 3 12 3 1',
       '11 4 23 2 5',
       '101 12 3 21 10',
       '1 4 5 2 2',
       '5 22 33 11 1']);