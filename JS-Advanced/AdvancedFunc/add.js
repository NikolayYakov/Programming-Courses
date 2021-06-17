function solve(number){
   return function(add){
       let result =number + add;
      return result;
      
   }
}
let add5 = solve(5);
console.log(add5(2));
console.log(add5(3));
