import {editMeme,getMemeById} from '../api/data.js'
import { html } from "../../node_modules/lit-html/lit-html.js"
const temp = (meme,submit)=>html`
          <section id="edit-meme">
            <form @submit = ${submit} id="edit-form">
                <h1>Edit Meme</h1>
                <div class="container">
                    <label for="title">Title</label>
                    <input value=${meme.title} id="title" type="text" placeholder="Enter Title" name="title">
                    <label for="description">Description</label>
                    <textarea id="description" placeholder="Enter Description" name="description">
                            ${meme.description}
                        </textarea>
                    <label for="imageUrl">Image Url</label>
                    <input value=${meme.imageUrl} id="imageUrl" type="text" placeholder="Enter Meme ImageUrl" name="imageUrl">
                    <input type="submit" class="registerbtn button" value="Edit Meme">
                </div>
            </form>
        </section>
`
export async function editPage(ctx){
    let id = ctx.params.id;
    let meme = await getMemeById(id);
    ctx.render(temp(meme,submit));
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
        let result = {
            title : title,
            description:desc,
            imageUrl:img,
        }
        await editMeme(id,result);
        ctx.page.redirect(`/details/${id}`);
    }
    ctx.navigation();
}