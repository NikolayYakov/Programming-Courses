function solve(input){
    let result = [];
    let products = [];
    while(input.length>0){
        let isThere = false;
        
        let [name,product,price] = input.shift().split(' | ');
        price = Number(price);
        const city = {
            name,
            product,
            price
            }
            
         for(let i = 0;i<result.length;i++){
             if(result[i].name===city.name&&result[i].product===city.product){
                 result[i].price = city.price;
                 isThere = true;
                 break;
             }
              
         }
         if(isThere===false){
             result.push(city);
             products.push(city.product);
         }
    }
    let sortedResult = result.slice(0);
    sortedResult.sort((a,b)=>(a.price>b.price)?1:-1);
    let ready = [];
    for(let i = 0;i<sortedResult.length;i++){
        let exist = false;
        let product = sortedResult[i].product;
        let price = sortedResult[i].price;
        for(let j =0;j<ready.length;j++){
            if(product===ready[j].product&&price!=ready[j].price){
                exist = true;
            }

        }
        if(exist===false){
            ready.push(sortedResult[i])
        }
    }
    let readyUpdated = [];
    for(let i = 0;i<ready.length;i++){
        let currect;
        for(let j = 0;j<ready.length;j++){
            
            if(i!=j&&ready[i].product==ready[j].product){
                let firstIndex = result.indexOf(ready[i]);
                let secondIndex = result.indexOf(ready[j]);
                if(firstIndex>secondIndex){
                    currect = ready[j];

                }
                else{
                    currect = ready[i];
                }
            }
            else{
                currect = ready[i];
            }
        }
        if(readyUpdated.includes(currect)==false){
            readyUpdated.push(currect);
        }
    }
    let finalResult =[];
    for(let i = 0;i<products.length;i++){
       let currect = readyUpdated.find(a=>a.product==products[i]);
       
       if(currect&&finalResult.includes(currect)==false){
           finalResult.push(currect);
       }
        
    }
    for (const products of finalResult) {
        console.log(`${products.product} -> ${products.price} (${products.name})`);
    }

}
solve (['Sofia City | Audi | 100000',
    'Sofia City | BMW | 100000',
    'Sofia City | Mitsubishi | 10000',
    'Sofia City | Mercedes | 10000',
    'Sofia City | NoOffenseToCarLovers | 0',
    'Mexico City | Audi | 1000',
    'Mexico City | BMW | 99999',
    'New York City | Mitsubishi | 10000',
    'New York City | Mitsubishi | 1000',
    'Mexico City | Audi | 100000',
    'Washington City | Mercedes | 1000'])