import { html } from "../../node_modules/lit-html/lit-html.js"
import {createBook} from "../api/data.js"
const temp = (onsubmit)=>html`
 <section id="create-page" class="create">
    <form @submit=${onsubmit} id="create-form" action="" method="">
        <fieldset>
            <legend>Add new Book</legend>
            <p class="field">
                <label for="title">Title</label>
                <span class="input">
                    <input type="text" name="title" id="title" placeholder="Title">
                </span>
            </p>
            <p class="field">
                <label for="description">Description</label>
                <span class="input">
                    <textarea name="description" id="description" placeholder="Description"></textarea>
                </span>
            </p>
            <p class="field">
                <label for="image">Image</label>
                <span class="input">
                    <input type="text" name="imageUrl" id="image" placeholder="Image">
                </span>
            </p>
            <p class="field">
                <label for="type">Type</label>
                <span class="input">
                    <select id="type" name="type">
                        <option value="Fiction">Fiction</option>
                        <option value="Romance">Romance</option>
                        <option value="Mistery">Mistery</option>
                        <option value="Classic">Clasic</option>
                        <option value="Other">Other</option>
                    </select>
                </span>
            </p>
            <input class="button submit" type="submit" value="Add Book">
        </fieldset>
    </form>
</section>
`
export async function createPage(ctx){
    ctx.render(temp(submit));
    async function submit(e){
        e.preventDefault();
        let data = new FormData(e.target);
        let title = data.get('title');
        let desc = data.get('description');
        let img = data.get('imageUrl');
        let type = data.get('type');
        if(!title||!desc||!img||!type){
            return alert('bad data');
        }
        let final = {
             title:title,
             description:desc,
             imageUrl:img,
             type:type,
        }
        await createBook(final);
        ctx.page.redirect('/');
    }
    ctx.navigation();
    
}