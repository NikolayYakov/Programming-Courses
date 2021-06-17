function solve(...params){
   let occurances = {};
   let result = [];
   for (const obj of params) {
       let type = typeof(obj);
       result.push(`${type}: ${obj}`);
       occurances[type] = occurances[type]!==undefined?occurances[type]+1:1;
   } 
   
   Object.keys(occurances).sort((a,b)=>occurances[b]-occurances[a]).forEach(key=>{
       result.push(`${key} = ${occurances[key]}`);
   });
   for (const element of result) {
    console.log(element);
}
    
}
solve('cat', 42,15, function () { console.log('Hello world!'); },'besho');