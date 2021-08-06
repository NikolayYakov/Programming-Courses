import {editCar,getCarById} from '../api/data.js'
import { html } from "../../node_modules/lit-html/lit-html.js"
const temp = (car,submit)=>html`
<section id="edit-listing">
    <div class="container">
        <form @submit=${submit} id="edit-form">
            <h1>Edit Car Listing</h1>
            <p>Please fill in this form to edit an listing.</p>
            <hr>
            <p>Car Brand</p>
            <input type="text" placeholder="Enter Car Brand" name="brand" value="${car.brand}">

            <p>Car Model</p>
            <input type="text" placeholder="Enter Car Model" name="model" value="${car.model}">

            <p>Description</p>
            <input type="text" placeholder="Enter Description" name="description" value="${car.description}">

            <p>Car Year</p>
            <input type="number" placeholder="Enter Car Year" name="year" value="${car.year}">

            <p>Car Image</p>
            <input type="text" placeholder="Enter Car Image" name="imageUrl" value="${car.imageUrl}">

            <p>Car Price</p>
            <input type="number" placeholder="Enter Car Price" name="price" value="${car.price}">

            <hr>
            <input type="submit" class="registerbtn" value="Edit Listing">
        </form>
    </div>
</section>
`
export async function editPage(ctx){
    let id = ctx.params.id;
    let car = await getCarById(id);
    ctx.render(temp(car,submit));
    async function submit(e){
        e.preventDefault();
        let data = new FormData(e.target);
        let desc = data.get('description');
        let img = data.get('imageUrl');
        let brand = data.get('brand');
        let model = data.get('model');
        let year = data.get('year').toString();
        let price = data.get('price').toString();
        if(!brand||!desc||!img||!model||!year||!price){
            return alert('bad data');
        }
        let result = {
            brand:brand,
            model:model,
            description:desc,
            year:Number(year),
            imageUrl:img,
            price:Number(price),
        }
        console.log('click');
        await editCar(id,result);
        ctx.page.redirect(`/details/${id}`);
    }
    ctx.navigation();
}