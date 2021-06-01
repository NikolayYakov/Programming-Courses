function solve(input){
     const claculator = {
         '+': (first, Second)=> first+Second,
         '-': (first, Second)=> first-Second,
         '/': (first, Second)=> first/Second, 
         '*': (first, Second)=> first*Second 

     }
    
let numbers = [];
for (const element of input) {
    if(typeof(element)==="number"){
        numbers.push(element);
    }else{
        if(numbers.length<2){
            console.log('Error: not enough operands!');
            break;
        }
        let second = numbers.pop();
        let first = numbers.pop();
        numbers.push(claculator[element](first,second));

    }
}
if(numbers.length>1){
    console.log('Error: too many operands!');

}else{
    console.log(numbers.pop());
}
}
solve([-1,
    1,
    '+',
    101,
    '*',
    18,
    '+',
    3,
    '/']);