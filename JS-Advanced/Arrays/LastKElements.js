function solve(n,k){
    let length = Number(n);
    let fibonachi = Number(k);
    let result = [];
    result[0] = 1;
    for(let i=1;i<length;i++){
        let sum =0;
        let start = Math.max(0,i-fibonachi);
        for(let j = start;j<i;j++){
            sum+=result[j];
        }
        result[i] = sum;
    }
     return result;
}
solve(6, 3);