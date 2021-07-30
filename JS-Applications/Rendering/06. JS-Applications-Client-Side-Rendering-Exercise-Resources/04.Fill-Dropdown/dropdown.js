import {temp} from "./temp.js";
import {render} from "./node_modules/lit-html/lit-html.js"
let root = document.getElementById('menu');
let text = document.getElementById('itemText');
let btn = document.querySelector('input[type="submit"]');
function addItem() {
    while(root.childElementCount>0){
        root.removeChild(root.children[0]);
    }
    fetch('http://localhost:3030/jsonstore/advanced/dropdown',{
        method:"POST",
        headers:{"Content-Type":"Application/json"},
        body:JSON.stringify({text:text.value}),
    });
    load();
}
async function load(){
   let cities = await (await fetch('http://localhost:3030/jsonstore/advanced/dropdown')).json();
   let arr = [];
   for (const key in cities) {
        arr.push(cities[key]);
   }
   render(arr.map(temp),root);
   
}
btn.addEventListener('click',addItem);

load();