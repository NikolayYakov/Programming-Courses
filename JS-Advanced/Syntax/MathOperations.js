function solve(a,b,symbol){
    let result = 0;
    if(symbol=='+'){
        result= a+b;

    }
    else if(symbol=='-'){
        result=a-b;
    }
    else if(symbol=='*'){
        result= a*b;
    }
    else if(symbol=='/'){
        result = a/b;
    }
    else if(symbol=='%'){
        result = a%b;
    }
    else{
        result = a**b;
    }
    console.log(result);
i}
solve(5,6,'');