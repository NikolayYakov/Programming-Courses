let dealership = {
    newCarCost: function (oldCarModel, newCarPrice) {

        let discountForOldCar = {
            'Audi A4 B8': 15000,
            'Audi A6 4K': 20000,
            'Audi A8 D5': 25000,
            'Audi TT 8J': 14000,
        }

        if (discountForOldCar.hasOwnProperty(oldCarModel)) {
            let discount = discountForOldCar[oldCarModel];
            let finalPrice = newCarPrice - discount;
            return finalPrice;
        } else {
            return newCarPrice;
        }
    },

    carEquipment: function (extrasArr, indexArr) {
        let selectedExtras = [];
        indexArr.forEach(i => {
            selectedExtras.push(extrasArr[i])
        });

        return selectedExtras;
    },

    euroCategory: function (category) {
        if (category >= 4) {
            let price = this.newCarCost('Audi A4 B8', 30000);
            let total = price - (price * 0.05)
            return `We have added 5% discount to the final price: ${total}.`;
        } else {
            return 'Your euro category is low, so there is no discount from the final price!';
        }
    }
}
let assert = require('chai').assert;
describe('test',()=>{
    describe('newCarCost',()=>{
        it('should give discount when you retunr your old car',()=>{
            assert.equal(dealership.newCarCost('Audi A4 B8',100000),85000);
            assert.equal(dealership.newCarCost( 'Audi A6 4K',100000),80000);
            assert.equal(dealership.newCarCost('Audi A8 D5',100000),75000);
            assert.equal(dealership.newCarCost('Audi TT 8J',100000),86000);

        })
        it('should not give discount when not returning an old car',()=>{
            assert.equal(dealership.newCarCost('Ford Focus',100000),100000);
            assert.equal(dealership.newCarCost('',100000),100000);
            assert.equal(dealership.newCarCost(undefined,100000),100000);
            assert.equal(dealership.newCarCost(null,100000),100000);


            

        })
    })
    describe('carEquipment',()=>{
        it('should retunr array with extras',()=>{
            let arr = [`heated seats`, `sliding roof`, `sport rims`, `navigation`];
            let index = [0,1,3];
            let result = [`heated seats`, `sliding roof`, `navigation`];
            assert.equal(JSON.stringify(dealership.carEquipment(arr,index)),JSON.stringify(result));
        })
    })
    describe('euroCategory',()=>{
        it('when category is over 4 get 5% discout',()=>{
            let total = 15000 - (15000 * 0.05)
            assert.equal(dealership.euroCategory(4),`We have added 5% discount to the final price: ${total}.`)
            assert.equal(dealership.euroCategory(5),`We have added 5% discount to the final price: ${total}.`)

        })
        it('should retunr string when under 4',()=>{
            assert.equal(dealership.euroCategory(3),`Your euro category is low, so there is no discount from the final price!`)
            
        })
        
    })
})