function solve(car){
    const engine = {
        smallEngine: {power: 90, volume: 1800},
        normalEngine: {power: 120, volume: 2400},
        monsterEngine:  {power: 200, volume: 3500}

    }
    const carriage = {
        hatchback: { type: 'hatchback', color: null },
        coupe: { type: 'coupe', color: null }

    }
    const readyCar = {

    }
    readyCar.model = car.model;
    if(car.power<=90){
        readyCar.engine = engine.smallEngine;
    }else if(car.power<=120){
        readyCar.engine = engine.normalEngine;
    }else{
        readyCar.engine = engine.monsterEngine;
    }
    if(car.carriage === 'hatchback'){
        readyCar.carriage = carriage.hatchback;

    }else{
        readyCar.carriage = carriage.coupe;
    }
    readyCar.carriage.color = car.color;
    let size = Math.floor(car.wheelsize);
    if(size%2===0){
        size--;
    }
    readyCar.wheels = [size,size,size,size];
    return readyCar;

}
let car = solve({ model: 'VW Golf II',
    power: 90,
    color: 'blue',
    carriage: 'hatchback',
    wheelsize: 14 })
    console.log(car);