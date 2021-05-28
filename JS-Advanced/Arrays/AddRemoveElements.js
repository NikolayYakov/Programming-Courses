function solve(input){
    let result = [];
    for(let i =0;i<input.length;i++){
        if(input[i]=='add'){
            result.push(i+1);
        }else{
            if(result.length>0){
                result.pop();
            }
        }

    }
    if(result.length==0){
        console.log('Empty');
    }else{
        for (const element of result) {
            console.log(element);
        }
    }
    
}
solve(['remove','remove','remove']);
