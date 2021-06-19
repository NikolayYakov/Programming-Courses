const lookupChar = require('../charLookUp');
let assert  = require('chai').assert;
describe('test',()=>{
    it('should return undefined if first parameter is not a string',()=>{
        assert.equal(lookupChar(1,2),undefined);
        assert.equal(lookupChar({},2),undefined);
        assert.equal(lookupChar(function(){},2),undefined);
        assert.equal(lookupChar(undefined,2),undefined);
        assert.equal(lookupChar(null,2),undefined);

        
    })
    it('should return undefined if the second parameter is not an integer',()=>{
         assert.equal(lookupChar('assd','das'),undefined);
         assert.equal(lookupChar('assd',{}),undefined);
         assert.equal(lookupChar('assd',function(){}),undefined);
         assert.equal(lookupChar('assd',NaN),undefined);
         assert.equal(lookupChar('assd',null),undefined);
         assert.equal(lookupChar('assd',undefined),undefined);
         assert.equal(lookupChar('assd',1.2321),undefined);



    })
    it('should retun error when index is outside the array',()=>{
        assert.equal(lookupChar('assd',-1),'Incorrect index');
        assert.equal(lookupChar('assd',4),'Incorrect index');
        assert.equal(lookupChar('assd',5),'Incorrect index');


    })
    it('should retun char when correct',()=>{
        assert.equal(lookupChar('hello',0),'h');
        assert.equal(lookupChar('hello',4),'o');

        
    })
})