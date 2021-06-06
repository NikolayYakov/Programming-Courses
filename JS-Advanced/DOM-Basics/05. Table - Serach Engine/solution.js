function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      let table = document.querySelectorAll('tbody tr td');   
      let arr = Array.from(table);
      for(let i = 0;i<arr.length;i+=3){
         let parent = arr[i].parentNode;
         parent.classList.remove('select');
      }

      let search = document.getElementById('searchField');
      arr = arr.filter(x=>x.textContent.includes(search.value));
      for (const element of arr) {
         let parent = element.parentNode;
         parent.classList.add("select");
      }
      search.value = null;
   }
}