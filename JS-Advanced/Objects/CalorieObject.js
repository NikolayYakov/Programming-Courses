function solve(input){
    const calObj = {

    }
     while(input.length>0){
         let product = input.shift();
         let cal = Number(input.shift());
         calObj[product] = cal;

     }
     console.log(calObj);
}
solve(['Yoghurt','48','Rise','138', 'Apple','52']);