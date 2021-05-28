function solve(input){
    let main = 0;
    let orto = 0;
    for(let i = 0;i<input.length;i++){
        main+=input[i][i];
        orto+=input[i][input[i].length-1-i]

    }
     
    let result = `${main} ${orto}`;
    console.log(result);

}
solve([[3, 5, 17],
    [-1, 7, 14],
    [1, -8, 89]]);