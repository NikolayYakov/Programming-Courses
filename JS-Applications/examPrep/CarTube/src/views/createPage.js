import { html } from "../../node_modules/lit-html/lit-html.js"
import {createCar} from "../api/data.js"
const temp = (onsubmit)=>html`
<section id="create-listing">
    <div class="container">
        <form @submit = ${onsubmit} id="create-form">
            <h1>Create Car Listing</h1>
            <p>Please fill in this form to create an listing.</p>
            <hr>

            <p>Car Brand</p>
            <input type="text" placeholder="Enter Car Brand" name="brand">

            <p>Car Model</p>
            <input type="text" placeholder="Enter Car Model" name="model">

            <p>Description</p>
            <input type="text" placeholder="Enter Description" name="description">

            <p>Car Year</p>
            <input type="number" placeholder="Enter Car Year" name="year">

            <p>Car Image</p>
            <input type="text" placeholder="Enter Car Image" name="imageUrl">

            <p>Car Price</p>
            <input type="number" placeholder="Enter Car Price" name="price">

            <hr>
            <input type="submit" class="registerbtn" value="Create Listing">
        </form>
    </div>
</section>
`
export async function createPage(ctx){
    ctx.render(temp(submit));
    async function submit(e){
        e.preventDefault();
        let data = new FormData(e.target);
        let brand = data.get('brand');
        let desc = data.get('description');
        let img = data.get('imageUrl');
        let model = data.get('model');
        let year = data.get('year');
        let price = data.get('price')
        if(!brand||!desc||!img||!model||!year||!price){
            return alert('bad data');
        }
        let final = {
            brand:brand,
            model:model,
            description:desc,
            year:Number(year),
            imageUrl:img,
            price:Number(price),
        }
        await createCar(final);
        ctx.page.redirect('/catalog');
    }
    ctx.navigation();
    
}