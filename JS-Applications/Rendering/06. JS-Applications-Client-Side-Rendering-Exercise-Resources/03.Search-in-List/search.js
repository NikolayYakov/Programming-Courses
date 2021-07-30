import {render} from "./node_modules/lit-html/lit-html.js"
import {towns} from "./towns.js"
import {temp} from "./townTemplate.js"
let root = document.getElementById('towns')
let searchBtn = document.querySelector('button');
let input = document.getElementById('searchText')
let result = document.getElementById('result');
function search() {
   render(temp(towns),root);
   searchBtn.addEventListener('click',(e)=>{
       let ul = document.querySelector('ul');
       let arr = Array.from(ul.children);
       for (const element of arr) {
         element.classList.remove('active');
         
      }
       let index = 0;
       for (const element of arr) {
          if(element.textContent.startsWith(input.value)&&input.value){
             element.classList.add('active');
             index++;
          }
          
       }
       result.textContent = `${index} matches found`;
       input.value = '';
   })

}
search();
