function solve(input){  
    if(isNaN(input)){
        console.log(`We can not calculate the circle area, because we receive a ${typeof(input)}.`);
    }
    else{
        let result = Math.PI*input**2;
        console.log(Math.round(result,2))

    }
    solve('number')
}