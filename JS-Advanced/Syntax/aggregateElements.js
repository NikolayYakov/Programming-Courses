function solve(input){
    let sum = 0;
    for(let i = 0;i<input.length;i++){
        sum+=input[i];

    }
    let inversion = 0;
    for(let i = 0;i<input.length;i++){
        inversion+=1/input[i];
    }
    let con='';
    for(let i =0;i<input.length;i++){
         con+=input[i].toString();

    }
    console.log(sum);
    console.log(inversion);
    console.log(con);


      
}
solve([2, 4, 8, 16]);
