function solve(input){
    let result = [];
    while(input.length>0){
        let number = input.shift();
        if(number<0){
            result.unshift(number);

        }
        else{
            result.push(number);
        }
    }
    for (const number of result) {
        console.log(number);
    }
}
solve([3, -2, 0, -1]);