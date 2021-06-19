const mathEnforcer = require('../MathEnforcer');
const assert = require('chai').assert;
describe('test',()=>{
    describe('add5',()=>{
        it('should return undefined when num is not a number',()=>{
            assert.equal(mathEnforcer.addFive('dasda'),undefined)
            assert.equal(mathEnforcer.addFive({}),undefined)
            assert.equal(mathEnforcer.addFive(function(){}),undefined)
            assert.equal(mathEnforcer.addFive(null),undefined)
            assert.equal(mathEnforcer.addFive(undefined),undefined)
            assert.equal(mathEnforcer.addFive([]),undefined)
        })
        it('shoud return num +5 when it is valid',()=>{
            assert.equal(mathEnforcer.addFive(5),10);
            assert.equal(mathEnforcer.addFive(5.5),10.5);
            assert.equal(mathEnforcer.addFive(-5),0);



        })
            
    })
    describe('subtract',()=>{
        it('should return undefied when it is not a number',()=>{
            assert.equal(mathEnforcer.subtractTen('dasda'),undefined)
            assert.equal(mathEnforcer.subtractTen({}),undefined)
            assert.equal(mathEnforcer.subtractTen(function() {}),undefined)
            assert.equal(mathEnforcer.subtractTen([]),undefined)
            assert.equal(mathEnforcer.subtractTen(null),undefined)
            assert.equal(mathEnforcer.subtractTen(undefined),undefined)



        })
        it('should return num-10 when valid',()=>{
            assert.equal(mathEnforcer.subtractTen(10),0);
            assert.equal(mathEnforcer.subtractTen(-10),-20);
            assert.equal(mathEnforcer.subtractTen(10.5),0.5);
            

        })
    })
    describe('sum',()=>{
        it('should return undefied when second param is not a number',()=>{
            assert.equal(mathEnforcer.sum(10,'dasda'),undefined)
            assert.equal(mathEnforcer.sum(10,{}),undefined)
            assert.equal(mathEnforcer.sum(10,function(){}),undefined)
            assert.equal(mathEnforcer.sum(10,null),undefined)
            assert.equal(mathEnforcer.sum(10,undefined),undefined)
            assert.equal(mathEnforcer.sum(10,[]),undefined)
        })
        it('should return undefied when first param is not a number',()=>{
            assert.equal(mathEnforcer.sum('dasda',10),undefined)
            assert.equal(mathEnforcer.sum({},10),undefined)
            assert.equal(mathEnforcer.sum(function(){},10),undefined)
            assert.equal(mathEnforcer.sum(null,10),undefined)
            assert.equal(mathEnforcer.sum(undefined,10),undefined)
            assert.equal(mathEnforcer.sum([],10),undefined)
        })
        it('should work when the two params are numbers',()=>{
            assert.equal(mathEnforcer.sum(10,10),20);
            assert.equal(mathEnforcer.sum(-10,-10),-20);
            assert.equal(mathEnforcer.sum(0,10),10);
            assert.equal(mathEnforcer.sum(10.5,10.5),21);
            assert.equal(mathEnforcer.sum(0,0),0);

        })
    })
})