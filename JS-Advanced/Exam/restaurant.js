class Restaurant{
    constructor(budget){
        this.budgetMoney = budget;
        this.menu = {};
        this.stockProducts = {};
        this.history = []; 

    }
    loadProducts(products) {
        let result = ``;
        for (const product of products) {
            let tockens = product.split(' ');
            let productName = tockens[0];
            let producQuontity = Number(tockens[1]);
            let price = Number(tockens[2]);
            if(this.budgetMoney<price){
                this.history.push(`There was not enough money to load ${producQuontity} ${productName}`);
                result+=`There was not enough money to load ${producQuontity} ${productName}\n`;
            }else{
                this.history.push(`Successfully loaded ${producQuontity} ${productName}`);
                result+=`Successfully loaded ${producQuontity} ${productName}\n`;
                this.budgetMoney-=price;
                if(this.stockProducts[productName]){
                    this.stockProducts[productName]+=producQuontity;
                }else{
                    this.stockProducts[productName] = producQuontity;
                }
            }
            
        }
        return result.trim();

    }
    addToMenu(meal,products,price){
        if(this.menu[meal]){
            return `The ${meal} is already in the our menu, try something different.`;
        }else{
            this.menu[meal] = {products: products,price:price};
            let count = Object.keys(this.menu).length;
            return `Great idea! Now with the ${meal} we have ${count} meals in the menu, other ideas?`
        }
    }
    showTheMenu(){
        let count = Object.keys(this.menu).length;
        if(count==0){
            return 'Our menu is not ready yet, please come later...';
        }else{
            let result = ``
            for (const key in this.menu) {
                 result+=`${key} - $ ${this.menu[key].price}\n`;
            }
            return result.trim();
        }
    }
    makeTheOrder(meal){
        if(!this.menu[meal]){
            return `There is not ${meal} yet in our menu, do you want to order something else?`;
        }else{
            let products = this.menu[meal].products;
            let hasProducts = true;
            for (const product of products) {
                let tockens = product.split(' ');
                let name = tockens[0];
                let quantity = Number(tockens[1]);
                if(!this.stockProducts[name]||this.stockProducts[name]<quantity){
                    hasProducts = false;
                    break;
                }
            }
            if(hasProducts==false){
                return `For the time being, we cannot complete your order (${meal}), we are very sorry...`
            }else{
                this.budgetMoney+=this.menu[meal].price;
            for (const product of products) {
                let tockens = product.split(' ');
                let name = tockens[0];
                let quantity = Number(tockens[1]);
                this.stockProducts[name]-=quantity;
            }
            return `Your order (${meal}) will be completed in the next 30 minutes and will cost you ${this.menu[meal].price}.`
            }
        }

    }
}
let kitchen = new Restaurant(1000);
kitchen.loadProducts(['Yogurt 30 3', 'Honey 50 4', 'Strawberries 20 10', 'Banana 5 1']);
kitchen.addToMenu('frozenYogurt', ['Yogurt 1', 'Honey 1', 'Banana 1', 'Strawberries 10'], 9.99);
console.log(kitchen.makeTheOrder('frozenYogurt'));


