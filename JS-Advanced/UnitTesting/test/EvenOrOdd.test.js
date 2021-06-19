const isOddOrEven = require('../EvenOrOdd');
const assert = require('chai').assert;
describe('test',()=>{
    it('should return undefied when no string',()=>{
        assert.equal(isOddOrEven(1),undefined);
        assert.equal(isOddOrEven(function(){}),undefined);
        assert.equal(isOddOrEven({}),undefined);
        assert.equal(isOddOrEven(null),undefined);
        assert.equal(isOddOrEven(undefined),undefined);
       

        
    })
    it('should return even when length is even',()=>{
        let value = '';
        assert.equal(isOddOrEven(value),'even');
        value = '1234';
        assert.equal(isOddOrEven(value),'even');
    })
    it('should return odd when odd',()=>{
        let value = '123';
        assert.equal(isOddOrEven(value),'odd');
    })
})