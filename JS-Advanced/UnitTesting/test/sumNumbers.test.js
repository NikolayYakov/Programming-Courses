const sum = require('../sumNumbers');
const assert = require('chai').assert;
describe('sum numbers test',()=>{
    it('When evrything is correct shout return true',()=>{
        let arr = [1,2,3,4,5];
        let correctSum = 15;
        let funcSum = sum(arr);
        assert.equal(correctSum,funcSum);
    })
    it('When sum is incorect shoud return false',()=>{
        let arr = [1,2,3,4,5];
        let correctSum = 16;
        let funcSum = sum(arr);
        assert.notEqual(correctSum,funcSum);
    })

})