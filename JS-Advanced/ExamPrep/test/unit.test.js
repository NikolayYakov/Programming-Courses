const numberOperations = {
    powNumber: function (num) {
        return num * num;
    },
    numberChecker: function (input) {
        input = Number(input);

        if (isNaN(input)) {
            throw new Error('The input is not a number!');
        }

        if (input < 100) {
            return 'The number is lower than 100!';
        } else {
            return 'The number is greater or equal to 100!';
        }
    },
    sumArrays: function (array1, array2) {

        const longerArr = array1.length > array2.length ? array1 : array2;
        const rounds = array1.length < array2.length ? array1.length : array2.length;

        const resultArr = [];

        for (let i = 0; i < rounds; i++) {
            resultArr.push(array1[i] + array2[i]);
        }

        resultArr.push(...longerArr.slice(rounds));

        return resultArr
    }
};
const assert = require('chai').assert;
describe('test',()=>{
    describe('powNumber',()=>{
        it('should return the power of a number',()=>{
            assert.equal(numberOperations.powNumber(5),25);
        })
    })
    describe('numberChecker',()=>{
        it('should throw when input is not an number',()=>{
            assert.throws(()=>numberOperations.numberChecker('asda'));
            assert.throws(()=>numberOperations.numberChecker({}));
            assert.throws(()=>numberOperations.numberChecker(function() {}));
            assert.throws(()=>numberOperations.numberChecker(undefined));

        })
        it('should return lower when lower than 100',()=>{
            assert.equal(numberOperations.numberChecker(99),'The number is lower than 100!')
        })
        it('should retunr greater or equal when x>=100',()=>{
            assert.equal(numberOperations.numberChecker(100),'The number is greater or equal to 100!')
            assert.equal(numberOperations.numberChecker(101),'The number is greater or equal to 100!')


        })
    })
    describe('array sum',()=>{
        it('when arrs are with the same length',()=>{
            let arr1 = [1,2,3,4];
            let arr2 = [4,3,2,1];
            assert.equal(JSON.stringify(numberOperations.sumArrays(arr1,arr2)),JSON.stringify([5,5,5,5]));
        })
        it('when the first array is longer',()=>{
            let arr1 = [1,2,3,4,6];
            let arr2 = [4,3,2,1];
            assert.equal(JSON.stringify(numberOperations.sumArrays(arr1,arr2)),JSON.stringify([5,5,5,5,6]));
        })
        it('when the second array is longer',()=>{
            let arr1 = [1,2,3,4];
            let arr2 = [4,3,2,1,6];
            assert.equal(JSON.stringify(numberOperations.sumArrays(arr1,arr2)),JSON.stringify([5,5,5,5,6]));
        })
            
        
    })
})
