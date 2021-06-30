class Bank{
    #bankName
    constructor (bankName){
        this.#bankName = bankName;
        this.allCustomers = [];
    }
    newCustomer (customer){
        let findCustomer = this.allCustomers.find(a=>a.firstName==customer.firstName&&a.lastName==customer.lastName);
        if(findCustomer){
            throw new Error(`${customer.firstName} ${customer.lastName} is already our customer!`);
        }
        this.allCustomers.push(customer);
        return customer;
    }
    depositMoney (personalId, amount){
        let findCustomer = this.allCustomers.find(a=>a.personalId==personalId);
        if(!findCustomer){
            throw new Error('We have no customer with this ID!');
        }
        if(!findCustomer.totalMoney){
            findCustomer.totalMoney = amount;
        }else{
            findCustomer.totalMoney+=amount;
        }
        if(!findCustomer.transactions){
            findCustomer.transactions = [];
            findCustomer.transactions.push(`${findCustomer.firstName} ${findCustomer.lastName} made deposit of ${amount}$!\n`);
        }
        else{
            findCustomer.transactions.push(`${findCustomer.firstName} ${findCustomer.lastName} made deposit of ${amount}$!\n`);
        }
        return `${findCustomer.totalMoney}$`;
    }
    withdrawMoney (personalId, amount){
        let findCustomer = this.allCustomers.find(a=>a.personalId==personalId);
        if(!findCustomer){
            throw new Error('We have no customer with this ID!');
        }
        if(findCustomer.totalMoney<amount){
            throw new Error(`${findCustomer.firstName} ${findCustomer.lastName} does not have enough money to withdraw that amount!`);
        }else{
            findCustomer.totalMoney-=amount;
            if(!findCustomer.transactions){
                findCustomer.transactions = [];
                findCustomer.transactions.push(`${findCustomer.firstName} ${findCustomer.lastName} withdrew ${amount}$!\n`);
            }else{
                findCustomer.transactions.push(`${findCustomer.firstName} ${findCustomer.lastName} withdrew ${amount}$!\n`)
            }
             

            return `${findCustomer.totalMoney}$`;
        }
    }
    customerInfo (personalId){
        let findCustomer = this.allCustomers.find(a=>a.personalId==personalId);
        if(!findCustomer){
            throw new Error('We have no customer with this ID!');
        }
        let result = ``;
        result+=`Bank name: ${this.#bankName}\n`;
        result+=`Customer name: ${findCustomer.firstName} ${findCustomer.lastName}\n`;
        result += `Customer ID: ${findCustomer.personalId}\n`;
        result+=`Total Money: ${findCustomer.totalMoney}$\n`;
        result+=`Transactions:\n`;
        for(let i =findCustomer.transactions.length-1;i>=0;i--){
            result+=`${i+1}. ${findCustomer.transactions[i]}`
        }
        return result.trim(); 
    }

}
try{
    let bank = new Bank('SoftUni Bank');

    console.log(bank.newCustomer({firstName: 'Svetlin', lastName: 'Nakov', personalId: 6233267}));
    console.log(bank.newCustomer({firstName: 'Mihaela', lastName: 'Mileva', personalId: 4151596}));
    
    bank.depositMoney(6233267, 250);
    console.log(bank.depositMoney(6233267, 250));
    bank.depositMoney(4151596,555);
    
    console.log(bank.withdrawMoney(6233267, 125));
    
    console.log(bank.customerInfo(6233267));
}catch(ex){
    console.log(ex.message);
}

