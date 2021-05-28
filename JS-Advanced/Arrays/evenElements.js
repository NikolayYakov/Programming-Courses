function solve(input){
    let even = [];
    for(let i = 0;i<input.length;i+=2){

        even.push(input[i]);
    }
    console.log(even.join(' '));
}
solve(['20','30','40','50','60']);