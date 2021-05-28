function solve(input){
    let smallestNumber = Number.MAX_SAFE_INTEGER;
    let secondSmallest = Number.MAX_SAFE_INTEGER;
    if(input.length==1){
        smallestNumber = input[0];
        secondSmallest = undefined;
    }
    else{
        for (const number of input) {
            if(number<smallestNumber){
                secondSmallest = smallestNumber;
                smallestNumber = number;
            }
            else if(number<secondSmallest){
                secondSmallest = number;
            }
        }

    }
   
    let result = `${smallestNumber} ${secondSmallest}`;
    console.log(result);
    
}
solve([0]);