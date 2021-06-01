function solve(input){
  
    let result = [];
     for(let town of input.slice(1)){
         let [empty,name,latitude,longitude] = town.split((/\s*\|\s*/));
         latitude = Number(latitude)
         latitude = Math.round((latitude + Number.EPSILON) * 100) / 100;
         longitude = Number(longitude);
         longitude = Math.round((longitude + Number.EPSILON) * 100) / 100;
         let towns = {Town: name,Latitude:latitude,Longitude:longitude};
         result.push(towns);


     }
     console.log(JSON.stringify(result));
}
 solve(['| Town | Latitude | Longitude |',
    '| Veliko Turnovo | 43.0757 | 25.6172 |',
    '| Monatevideo | 34.50 | 56.11 |']);