function solve(data,criteria){
   let json = JSON.parse(data);
   let isNotAll = criteria!=='all';
   
   let [key,value] = criteria.split('-');
   if(isNotAll===true){
     json = json.filter((obj)=>{
     
        if(obj[key]==value){
            return true;
        }
        return false;
    })
   } 
   


let index = 0;
for (const obj of json) {

    console.log(`${index}. ${obj.first_name} ${obj.last_name} - ${obj.email}`);
    index++;
}

 
   
}
solve(`[{
    "id": "1",
    "first_name": "Ardine",
    "last_name": "Bassam",
    "email": "abassam0@cnn.com",
    "gender": "Female"
  }, {
    "id": "2",
    "first_name": "Kizzee",
    "last_name": "Jost",
    "email": "kjost1@forbes.com",
    "gender": "Female"
  },  
{
    "id": "3",
    "first_name": "Evanne",
    "last_name": "Maldin",
    "email": "emaldin2@hostgator.com",
    "gender": "Male"
  }]`, 
'all'
);