function solve(input){
    function neighbors(element,row,col,input){
        let pairs = 0;
         
        if(row+1<input.length&&input[row+1][col]===element){
            pairs++;

        }if(col+1<input[row].length&&input[row][col+1]===element){
            pairs++;

        }
        return pairs;



    }
    let result = 0;
    for(let row = 0;row<input.length;row++){
        for(let col = 0;col<input[row].length;col++){
            result+=neighbors(input[row][col],row,col,input);

        }
    }
    console.log(result);
}
solve([['2','2','5','7','4'],
       ['4','0','5','3','4'],
       ['2','5','5','4','2']]);