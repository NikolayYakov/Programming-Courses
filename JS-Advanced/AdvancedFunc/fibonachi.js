function getFibonator(){
    let arr = []
    function fibo(){
        let current = 0;
        if(arr.length<2){
            current = 1;
            arr.push(1);
             
        }else{
          current = arr[arr.length-1]+arr[arr.length-2];
          arr.push(current); 
        }
        
        return current;
    }
    return fibo;
}
let fib = getFibonator();
console.log(fib()); // 1
console.log(fib()); // 1
console.log(fib()); // 2
console.log(fib()); // 3
console.log(fib()); // 5
console.log(fib()); // 8
console.log(fib()); // 13
