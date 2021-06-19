const createCalculator  = require('../addSubstract');
const assert = require('chai').assert;
describe('test',()=>{
    it('Should have a base value of 0',()=>{
        let value = createCalculator();
        assert.equal(value.get(),0);
    })
    it('Should add num to value when add is called',()=>{
        let value = createCalculator();
        value.add(1);
        assert.equal(value.get(),1);
    })
    it('Should add num(string) to value when add is called',()=>{
        let value = createCalculator();
        value.add('1');
        assert.equal(value.get(),1);
    })
    it('Should subs num to value when add is called',()=>{
        let value = createCalculator();
        value.add(10);
        value.subtract(4);
        assert.equal(value.get(),6);
    })
    it('Should subs num(string) to value when add is called',()=>{
        let value = createCalculator();
        value.add(10);
        value.subtract('4');
        assert.equal(value.get(),6);
    })
    it('Shoud return Nan when its not a number',()=>{
        let value = createCalculator();
        value.add('Hello');
        assert.isNaN(value.get());
    })
    it('Shoud return Nan when its not a number',()=>{
        let value = createCalculator();
        value.subtract('Hello');
        assert.isNaN(value.get());
    })
    it('Should subs num to value when add is called',()=>{
        let value = createCalculator();
        value.subtract(4);
        assert.equal(value.get(),-4)
    })   
    it('Should subs num to value when add is called',()=>{
        let value = createCalculator();
        value.subtract('4');
        assert.equal(value.get(),-4)
    })   
    it('Should subs num to value when add is called',()=>{
        let value = createCalculator();
        value.add(5);
        value.subtract('4');
        assert.equal(value.get(),1)
    })   
    it('Should subs num to value when add is called',()=>{
        let value = createCalculator();
        value.add(5);
        value.subtract('4');
        value.add(10);
        value.subtract(1);
        assert.equal(value.get(),10)
    })   
    it('should return 0 for get', () => {
        let value = createCalculator();

        value.add(10);
        value.subtract('2');
        value.add('2');
        value.subtract(4);
        assert.equal(value.get(),6);
         
    });
})