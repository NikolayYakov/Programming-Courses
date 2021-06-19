function solve(arr,startIndex,endIndex){
    if(!Array.isArray(arr)){
        return NaN;

    }
    if(startIndex<0){
        startIndex=0;
    }
    if(endIndex>arr.length-1){
        endIndex = arr.length-1;
    }
    let sum = 0;
    for(let i =startIndex;i<=endIndex;i++){
        if(isNaN(arr[i])){
            return NaN;
        }
        sum+=arr[i];
    }
    return sum

}
console.log(solve('text', 0, 2));