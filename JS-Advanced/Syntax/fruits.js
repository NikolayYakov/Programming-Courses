function solve(fruitName,weight,price){
    weight/=1000;
    let wholePrice = weight*price;
    
    console.log(`I need $${wholePrice.toFixed(2)} to buy ${weight.toFixed(2)} kilograms ${fruitName}.`);


}
solve('apple', 1563, 2.35);