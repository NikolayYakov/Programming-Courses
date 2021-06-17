function solve(num){
    let sum = 0;
    function inner(number){
        sum+=number;
        return inner;
    }
    inner.toString = ()=>{return sum};
    return inner(num);

}
solve(1)(6)(-3);