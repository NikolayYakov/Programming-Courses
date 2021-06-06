function search() {
   let search = document.getElementById('searchText');
   let list = document.querySelectorAll('#towns li');
   let result = document.getElementById('result');
   let townArray = Array.from(list);
   townArray = townArray.filter(t=>t.textContent.includes(search.value));
   list = townArray;
   
   console.log(list)
   for (const iterator of list) {
      iterator.style.fontWeight = 'bold';
      iterator.style.textDecoration = "underline";
      
   }
   result.textContent =`${townArray.length} matches found`; 

}
