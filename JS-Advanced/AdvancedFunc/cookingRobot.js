function solution(){
   const storage = {
    protein: 0,
    carbohydrate:0,
    fat: 0,
    flavour: 0
   }
   const menu = {
       apple: {carbohydrate: 1,flavour:2},
       lemonade: {carbohydrate:10,flavour:20},
       burger: {carbohydrate:5,fat:7,flavour:3},
       eggs: {protein:5,fat:1,flavour:1},
       turkey: {protein:10,carbohydrate:10,fat:10,flavour:10}   
   }
   return function(command){
       let tockens = command.split(' ');
      
       if(tockens[0]==='restock'){
           storage[tockens[1]]+=Number(tockens[2]);
           return 'Success';
       }else if(tockens[0]==='report'){
           let result = [];
           for (const key in storage ) {
               
                 result.push(`${key}=${storage[key]}`);
           }
           return result.join(' ');
       }else if(tockens[0]==='prepare'){
           let igridiants = JSON.parse(JSON.stringify(menu[tockens[1]]))
           let quantity = Number(tockens[2]);
           for (const key in igridiants) {
               igridiants[key]*=quantity;
               if(igridiants[key]>storage[key]){
                   return `Error: not enough ${key} in stock`;
               }
           }
           for (const key in igridiants) {
                storage[key]-=igridiants[key];
           }
           return 'Success'

       }

   }

}
 



