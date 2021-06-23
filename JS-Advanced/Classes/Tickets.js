function solve(input,sorting){
    let tickets = [];
    class Ticket{
        constructor(destination,price,status){
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
         
    }
    for (const obj of input) {
        let tockens = obj.split('|');
        tickets.push(new Ticket(tockens[0],Number(tockens[1]),tockens[2]));


    }
    if(sorting == 'destination'){
        tickets.sort((a,b)=>a.destination.localeCompare(b.destination));
    }else if(sorting=='price'){
        tickets.sort((a,b)=>a.price-b.price);
    }else if(sorting=='status'){
        tickets.sort((a,b)=>a.status.localeCompare(b.status));

    }
    return tickets;
}
console.log(solve(['Philadelphia|94.20|available',
'New York City|95.99|available',
'New York City|95.99|sold',
'Boston|126.20|departed'],
'price'
));