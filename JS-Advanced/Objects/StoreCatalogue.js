function solve(input){
    const catalogue = {};
    let keys = [];
    while(input.length>0){
        let [product,price] = input.shift().split(' : ');
        catalogue[product] = Number(price);
        keys.push(product);

    }
  keys.sort((a,b)=>a.localeCompare(b));
  let preLeter = null;
  for (const key of keys) {
      let letter = key[0];
      if(letter!==preLeter){
          console.log(letter);
          preLeter = letter;

      }
      console.log(`  ${key}: ${catalogue[key]}`);
  }


}
solve(['Appricot : 20.4',
    'Fridge : 1500',
    'TV : 1499',
    'Deodorant : 10',
    'Boiler : 300',
    'Apple : 1.25',
    'Anti-Bug Spray : 15',
    'T-Shirt : 10'])