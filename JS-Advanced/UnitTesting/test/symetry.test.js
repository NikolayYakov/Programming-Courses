const isSymmetric = require('../symetry');
const assert = require('chai').assert;
describe('symetry test',()=>{
    it('should return false when not symetric',()=>{
        let arr = [1,2,3,3,4];
        let value = isSymmetric(arr);
        assert.equal(value,false);

    })
    it('Should return true when symetric',()=>{
        let arr = [1,2,3,2,1];
        let value = isSymmetric(arr);
        assert.equal(value,true);
    })
    it('when different type return false',()=>{
        let arr = [1,'1'];
        let value = isSymmetric(arr);
        assert.equal(value,false);
    })
    it('When no arr return false',()=>{
        assert.equal(isSymmetric(null),false);
        assert.equal(isSymmetric(NaN),false);
        assert.equal(isSymmetric(undefined),false);
        assert.equal(isSymmetric('DSA'),false);
        assert.equal(isSymmetric(1),false);
        assert.equal(isSymmetric({}),false);
        assert.equal(isSymmetric(function(){}),false);

    })
    it('text symetry return true',()=>{
        let arr = ['a','b','a'];
        let value = isSymmetric(arr);
        assert.equal(value,true);
    })
    it('text symetry return false',()=>{
        let arr = ['a','b','c'];
        let value = isSymmetric(arr);
        assert.equal(value,false);
    })
})