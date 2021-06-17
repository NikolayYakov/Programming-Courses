function solve(input){
    let result = [];
    const obj = {
      add: function(string){
          result.push(string);
      },
      remove: function(string){
         result = result.filter(a=>a!=string);
      },
      print: function(){
          console.log(result.join(','))
      } 
    }
    for (const com of input) {
        let [comand,value] = com.split(' ');
         obj[comand](value);
    }
    
}
solve(['add hello', 'add again', 'remove hello', 'add again', 'print']);