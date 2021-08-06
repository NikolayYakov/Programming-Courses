import { html } from "../../node_modules/lit-html/lit-html.js"
import {createMeme} from "../api/data.js"
const temp = (onsubmit)=>html`
           <section id="create-meme">
            <form @submit = ${onsubmit} id="create-form">
                <div class="container">
                    <h1>Create Meme</h1>
                    <label for="title">Title</label>
                    <input id="title" type="text" placeholder="Enter Title" name="title">
                    <label for="description">Description</label>
                    <textarea id="description" placeholder="Enter Description" name="description"></textarea>
                    <label for="imageUrl">Meme Image</label>
                    <input id="imageUrl" type="text" placeholder="Enter meme ImageUrl" name="imageUrl">
                    <input type="submit" class="registerbtn button" value="Create Meme">
                </div>
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
        console.log(title,desc,img);
        if(!title||!desc||!img){
            return alert('bad data');
        }
        await createMeme(title,desc,img);
        ctx.page.redirect('/catalog');
    }
    ctx.navigation();
    
}