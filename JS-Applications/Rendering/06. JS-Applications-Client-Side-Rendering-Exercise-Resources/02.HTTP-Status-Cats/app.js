import {catsTemplate} from "./catsTemp.js"
import { render } from "./node_modules/lit-html/lit-html.js"
import {cats} from "./catSeeder.js"
let arr = [];
for (const key in cats) {
     arr.push(cats[key]);
}
let root = document.getElementById('allCats');
render(catsTemplate(cats,action),root);
function action(e){
    if(e.target.textContent == 'Show status code'){
        e.target.parentNode.children[1].style.display = 'block';
        e.target.textContent = 'Hide status code';
    }
    else{
        e.target.parentNode.children[1].style.display = 'none';
        e.target.textContent = 'Show status code';
    }
   
}