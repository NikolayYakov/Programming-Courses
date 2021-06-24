class Parking {
    constructor(capacity){
        this.capacity = capacity;
        this.vehicles = []; 

    }
    addCar(carModel, carNumber){
        if(this.capacity<=this.vehicles.length){
            throw new Error('Not enough parking space.')
        }
        let obj = {carModel:carModel,carNumber:carNumber,payed:false};
        this.vehicles.push(obj);
        return `The ${carModel}, with a registration number ${carNumber}, parked.`

    }
    removeCar(carNumber){
        let car = this.vehicles.find(a=>a.carNumber==carNumber);
        if(!car){
            throw new Error(`The car, you're looking for, is not found.`);
            
        }
        if(car.payed==false){
            throw new Error(`${carNumber} needs to pay before leaving the parking lot.`);

        }
        let index = this.vehicles.indexOf(car);
        this.vehicles.splice(index,1);
        return `${car.carNumber} left the parking lot.`
    }
    pay(carNumber){
        let car = this.vehicles.find(a=>a.carNumber==carNumber);
        if(!car){
            throw new Error(`${carNumber} is not in the parking lot.`);
            
        }
        
        if(car.payed ==true){
            throw new Error(`${carNumber}'s driver has already payed his ticket.`);

        }
        let index = this.vehicles.indexOf(car);
        this.vehicles[index].payed = true;
        return `${carNumber}'s driver successfully payed for his stay.`
    } 
    getStatistics(carNumber) {
        let result = '';
        if(!carNumber){
            result = `The Parking Lot has ${this.capacity-this.vehicles.length} empty spots left.\n`;
            this.vehicles.sort((a,b)=>a.carModel.localeCompare(b.carModel));
            for (const car of this.vehicles) {
                let payed = '';
                if(car.payed ==true){
                    payed = 'Has payed';

                }else{
                    payed = 'Not payed';
                    
                }
                result+=`${car.carModel} == ${car.carNumber} - ${payed}\n`;
            }

        }else{
            let car = this.vehicles.find(a=>a.carNumber==carNumber)
            let payed = '';
                if(car.payed ==true){
                    payed = 'Has payed';

                }else{
                    payed = 'Not payed';
                    
                }
            result = `${car.carModel} == ${car.carNumber} - ${payed}`;
            
        }
        return result.trim();
    }

}
try{
    const parking = new Parking(12);

    console.log(parking.addCar("Volvo t600", "TX3691CA"));
    console.log(parking.addCar("Aolvo t600", "TX4691CA"));
    console.log(parking.getStatistics("TX4691CA"));
    
    console.log(parking.pay("TX3691CA"));
    console.log(parking.removeCar("TX3691CA"));
}catch(ex){
    console.log(ex.message);
}

