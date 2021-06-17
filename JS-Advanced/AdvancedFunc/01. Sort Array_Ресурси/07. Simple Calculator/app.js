function calculator() {
    let numFirst;
    let numSecond;
    let resultAdd;
   return {
       init: function(selector1, selector2, resultSelector){
           let num1 = document.querySelector(selector1);
           let num2 = document.querySelector(selector2);
           let result = document.querySelector(resultSelector);
           numFirst = num1;
           numSecond = num2;
           resultAdd = result;
        

       },
       add: function(){
           resultAdd.value = Number(numFirst.value)+Number(numSecond.value);
       },
       subtract: function(){
        resultAdd.value = Number(numFirst.value)-(numSecond.value);

       } 
       
   }
}
const calculate = calculator (); 
calculate.init ('#num1', '#num2', '#result'); 





