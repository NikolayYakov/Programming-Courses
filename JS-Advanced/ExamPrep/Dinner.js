class ChristmasDinner{
    #budgetValue;
    constructor(budget){
        this.budget = budget;
        this.dishes = [];
        this.products = [];
        this.guests = {}; 
    }
    set budget(value){
        if(value<0){
            throw new Error('The budget cannot be a negative number');
        }else{
            this.#budgetValue = value;
        }
    }
    get budget(){
        return this.#budgetValue;
    }
    shopping(product){
        let productType = product[0];
        let price = product[1];
        if(this.budget-price<0){
            throw new Error('Not enough money to buy this product');
        }else{
            this.products.push(productType);
            this.budget-=price;
            return `You have successfully bought ${productType}!`;
        }
    }
    recipes(recipe){
        let productsRecep = recipe.productsList;
        let isThere = true;
        for (const product of productsRecep) {
            if(!this.products.includes(product)){
                isThere = false;
                break;

            }
        }
        if(!isThere){
            throw new Error('We do not have this product');
        }else{
            this.dishes.push(recipe);
            return `${recipe.recipeName} has been successfully cooked!`;
        }
    }
    inviteGuests(name, dish){
        let findDish = this.dishes.find(a=>a.recipeName===dish);
        if(!findDish){
            throw new Error('We do not have this dish');
        }
        
        else if(this.guests[name]){
            throw new Error('This guest has already been invited')
        }else{
            this.guests[name] = dish;
            return `You have successfully invited ${name}!`;

        }
    }
    showAttendance(){
        let result = ``;
        for (const key in this.guests) {
            let find = this.dishes.find(a=>a.recipeName==this.guests[key]);
            result+=`${key} will eat ${this.guests[key]}, which consists of ${find.productsList.join(', ')}\n`;
        }
        return result.trim();
    }
}
let dinner = new ChristmasDinner(300);

dinner.shopping(['Salt', 1]);
dinner.shopping(['Beans', 3]);
dinner.shopping(['Cabbage', 4]);
dinner.shopping(['Rice', 2]);
dinner.shopping(['Savory', 1]);
dinner.shopping(['Peppers', 1]);
dinner.shopping(['Fruits', 40]);
dinner.shopping(['Honey', 10]);

dinner.recipes({
    recipeName: 'Oshav',
    productsList: ['Fruits', 'Honey']
});
dinner.recipes({
    recipeName: 'Folded cabbage leaves filled with rice',
    productsList: ['Cabbage', 'Rice', 'Salt', 'Savory']
});
dinner.recipes({
    recipeName: 'Peppers filled with beans',
    productsList: ['Beans', 'Peppers', 'Salt']
});

dinner.inviteGuests('Ivan', 'Oshav');
dinner.inviteGuests('Petar', 'Folded cabbage leaves filled with rice');
dinner.inviteGuests('Georgi', 'Peppers filled with beans');

console.log(dinner.showAttendance());
