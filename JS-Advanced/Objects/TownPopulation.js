function solve(input){
    const city= {
        
    }
    while(input.length>0){
        let info = input.shift();
        let [cityName,population] = info.split(' <-> ');
        population = Number(population);
        if(city[cityName]){
            city[cityName]+=population;
        }
        else{
            city[cityName] = population;
        }
         
    }
    for (const key in city) {
         console.log(`${key} : ${city[key]}`);
    }
}
solve(['Sofia <-> 1200000',
    'Montana <-> 20000',
    'New York <-> 10000000',
    'Washington <-> 2345000',
    'Las Vegas <-> 1000000']);