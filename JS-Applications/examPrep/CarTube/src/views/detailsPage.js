import { html } from "../../node_modules/lit-html/lit-html.js"
import {getUserInfo} from '../utility.js'
import {getCarById} from "../api/data.js"
const temp = (car,id)=>html`
<section id="listing-details">
    <h1>Details</h1>
    <div class="details-info">
        <img src=${car.imageUrl}>
        <hr>
        <ul class="listing-props">
            <li><span>Brand:</span>${car.brand}</li>
            <li><span>Model:</span>${car.model}</li>
            <li><span>Year:</span>${car.year}</li>
            <li><span>Price:</span>${car.price}$</li>
        </ul>

        <p class="description-para">${car.description}</p>
        ${car._ownerId==id?html`<div class="listings-buttons">
            <a href="/edit/${car._id}" class="button-list">Edit</a>
            <a href="/delete/${car._id}" class="button-list">Delete</a>
        </div>`:''};
        
    </div>
</section>
`
export async function detailsPage(ctx){
    let id = ctx.params.id;
    let car = await getCarById(id);
    console.log(car);
    let userId = getUserInfo();
    if(userId){
        ctx.render(temp(car,userId._id));
         
    
    }else{
        ctx.render(temp(car));
    }
    ctx.navigation();
}