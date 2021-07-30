import {contacts} from "./contacts.js"
import { render } from "./node_modules/lit-html/lit-html.js"
import {contatactTemplate} from "./contactTemplate.js"
function solve(){
    let parant = document.getElementById('contacts');
    render(contacts.map(contatactTemplate),parant);
    let buttons = document.querySelectorAll('.')
}

console.log('qlo');
document.addEventListener('DOMContentLoaded',solve);