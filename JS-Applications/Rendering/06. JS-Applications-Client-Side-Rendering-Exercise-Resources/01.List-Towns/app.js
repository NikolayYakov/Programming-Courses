
import {render} from './node_modules/lit-html/lit-html.js'
import {townsTemplate} from './townsTemplate.js'
let towns = document.getElementById('towns');
let button = document.getElementById('btnLoadTowns');
let root = document.getElementById('root')
button.addEventListener('click',(e)=>{
    let arr = towns.value.split(', ')
    e.preventDefault();
    render(townsTemplate(arr),root);
})