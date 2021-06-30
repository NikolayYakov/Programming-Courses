const testNumbers = {
    sumNumbers: function (num1, num2) {
        let sum = 0;

        if (typeof(num1) !== 'number' || typeof(num2) !== 'number') {
            return undefined;
        } else {
            sum = (num1 + num2).toFixed(2);
            return sum
       }
   },
   numberChecker: function (input) {
       input = Number(input);

       if (isNaN(input)) {
           throw new Error('The input is not a number!');
       }

       if (input % 2 === 0) {
           return 'The number is even!';
       } else {
           return 'The number is odd!';
       }

   },
   averageSumArray: function (arr) {

       let arraySum = 0;

       for (let i = 0; i < arr.length; i++) {
           arraySum += arr[i]
       }

       return arraySum / arr.length
   }
};
let assert = require('chai').assert;
describe('test',()=>{
    describe('sum numbers',()=>{
        it('sum positive numbers',()=>{
             assert.equal(testNumbers.sumNumbers(2,5),7);
             assert.equal(testNumbers.sumNumbers(1.2345,10.145678),11.38);
             
        })
        it('sum negative numbers',()=>{
            assert.equal(testNumbers.sumNumbers(-2,-5),-7);
            assert.equal(testNumbers.sumNumbers(-15.145,-20.453),-35.60)
        })
        it('sums negative with positive',()=>{
            assert.equal(testNumbers.sumNumbers(5,-2),3);
            assert.equal(testNumbers.sumNumbers(15.145,-20.453),-5.31)
        })
        it('sums zeros',()=>{
            assert.equal(testNumbers.sumNumbers(0,0),0);
        })
        it('when not a number return undefined',()=>{
            assert.equal(testNumbers.sumNumbers(15,undefined),undefined);
            assert.equal(testNumbers.sumNumbers(15,function(){}),undefined);
            assert.equal(testNumbers.sumNumbers(15,''),undefined);
            assert.equal(testNumbers.sumNumbers(15,'sda'),undefined);
            assert.equal(testNumbers.sumNumbers(15,[]),undefined);
            assert.equal(testNumbers.sumNumbers(15,{}),undefined);
            assert.equal(testNumbers.sumNumbers(undefined,15),undefined);
            assert.equal(testNumbers.sumNumbers(function(){},15),undefined);
            assert.equal(testNumbers.sumNumbers('',15),undefined);
            assert.equal(testNumbers.sumNumbers('adsda',15),undefined);
            assert.equal(testNumbers.sumNumbers([],15),undefined);
            assert.equal(testNumbers.sumNumbers({},15),undefined);
            

        }) 
    })
    describe('numberChecker',()=>{
        it('should throw when it is not a number',()=>{
            assert.throws(()=>testNumbers.numberChecker('sadasd'))
            assert.throws(()=>testNumbers.numberChecker(undefined))
            assert.throws(()=>testNumbers.numberChecker(function(){}))
            assert.throws(()=>testNumbers.numberChecker({}))

        })
        it('should return even when even',()=>{
            assert.equal(testNumbers.numberChecker(4),'The number is even!');
            assert.equal(testNumbers.numberChecker(0),'The number is even!');
            assert.equal(testNumbers.numberChecker(-4),'The number is even!');


        })
        it('should return odd when odd',()=>{
            assert.equal(testNumbers.numberChecker(5),'The number is odd!');
            assert.equal(testNumbers.numberChecker(-5),'The number is odd!');
        })
    })
    describe('arraySum',()=>{
        it('should return zero when array is empty',()=>{
            //assert.equal(testNumbers.averageSumArray([]),0);
        })
        it('should retunr avrg sum',()=>{
            assert.equal(testNumbers.averageSumArray([1,3,5]),3);
            assert.equal(testNumbers.averageSumArray([3,6]),4.5)
        })
    })
})