let pizzUni = {
    makeAnOrder: function (obj) {

        if (!obj.orderedPizza) {
            throw new Error('You must order at least 1 Pizza to finish the order.');
        } else {
            let result = `You just ordered ${obj.orderedPizza}`;
            if(obj.orderedDrink){
                result += ` and ${obj.orderedDrink}.`;
            }
            return result;
        }
    },

    getRemainingWork: function (statusArr) {

        const remainingArr = statusArr.filter(s => s.status != 'ready');

        if (remainingArr.length > 0) {

            let pizzaNames = remainingArr.map(p => p.pizzaName).join(', ')
            let pizzasLeft = `The following pizzas are still preparing: ${pizzaNames}.`

            return pizzasLeft;
        } else {
            return 'All orders are complete!'
        }

    },

    orderType: function (totalSum, typeOfOrder) {
        if (typeOfOrder === 'Carry Out') {
            totalSum -= totalSum * 0.1;

            return totalSum;
        } else if (typeOfOrder === 'Delivery') {

            return totalSum;
        }
    }
}
let assert = require('chai').assert;
describe('test',()=>{
    describe('make an order test',()=>{
        it('should throw when obj has not ordared',()=>{
           let obj = {orderedDrink: 'the name of the drink'}
           assert.throws(()=>pizzUni.makeAnOrder(obj));
        })
        it('should return result when pizza is ordered',()=>{
           let obj = {orderedPizza: 'the name of the pizza',orderedDrink: 'the name of the drink'}
           let result = `You just ordered ${obj.orderedPizza} and ${obj.orderedDrink}.`
           assert.equal(result,pizzUni.makeAnOrder(obj));

        })
        it('should return result when pizza is ordered, withoutDirnk',()=>{
            let obj = {orderedPizza: 'the name of the pizza'}
            let result = `You just ordered ${obj.orderedPizza}`
            assert.equal(result,pizzUni.makeAnOrder(obj));
 
        })

        
    })
    describe('checking status work',()=>{
        it('when all are ready return msg',()=>{
            let arr = [{pizzaName: 'Marga', status: 'ready'},{pizzaName: 'Peta', status: 'ready'},{pizzaName: 'Maria', status: 'ready'}];
            let msg = 'All orders are complete!';
            assert.equal(msg,pizzUni.getRemainingWork(arr));
        })
        it('shout return msg when some are not ready',()=>{
            let arr = [{pizzaName: 'Marga', status: 'preparing'},{pizzaName: 'Peta', status: 'preparing'},{pizzaName: 'Maria', status: 'ready'}];
            let msg = 'The following pizzas are still preparing: Marga, Peta.';
            assert.equal(msg,pizzUni.getRemainingWork(arr));
        })
    
    })
    describe('order tests',()=>{
        it('should give discount when number its carry out',()=>{
            assert.equal(pizzUni.orderType(100,'Carry Out'),90);
        })
        it('should not give discount when number its delivery',()=>{
            assert.equal(pizzUni.orderType(100,'Delivery'),100);
        })
    })
    
})
