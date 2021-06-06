function solve() {
   let stringToModify = document.getElementById('text');
   let convention = document.getElementById('naming-convention');
   let  result = document.getElementById('result');
   let words = stringToModify.value.split(' ').map(w=>w.toLowerCase());
  
   words = words.map(w=>w.charAt(0).toUpperCase()+w.slice(1));
    
   if(convention.value==='Camel Case'){
     words[0] = words[0].toLowerCase();
     result.textContent = words.join('');
   }else if(convention.value==='Pascal Case'){
    result.textContent = words.join('');

   }
   else{
      result.textContent = 'Error!';
   } 
   

}