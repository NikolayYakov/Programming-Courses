import {editBook,getBookById} from '../api/data.js'
import { html } from "../../node_modules/lit-html/lit-html.js"
const temp = (book,submit)=>html`
 <section @submit=${submit} id="edit-page" class="edit">
    <form id="edit-form" action="#" method="">
        <fieldset>
            <legend>Edit my Book</legend>
            <p class="field">
                <label for="title">Title</label>
                <span class="input">
                    <input type="text" name="title" id="title" value=${book.title}>
                </span>
            </p>
            <p class="field">
                <label for="description">Description</label>
                <span class="input">
                    <textarea name="description"
                        id="description">${book.description}</textarea>
                </span>
            </p>
            <p class="field">
                <label for="image">Image</label>
                <span class="input">
                    <input type="text" name="imageUrl" id="image" value=${book.imageUrl}>
                </span>
            </p>
            <p class="field">
                <label for="type">Type</label>
                <span class="input">
                    <select id="type" name="type" value=${book.type}>
                        <option id="Fiction" value="Fiction">Fiction</option>
                        <option id="Romance" value="Romance">Romance</option>
                        <option id="Mistery" value="Mistery">Mistery</option>
                        <option id="Classic" value="Classic">Clasic</option>
                        <option id="Other" value="Other">Other</option>
                    </select>
                </span>
            </p>
            <input class="button submit" type="submit" value="Save">
        </fieldset>
    </form>
</section>
`
export async function editPage(ctx){
    let id = ctx.params.id;
    let book = await getBookById(id);
    ctx.render(temp(book,submit));
    document.getElementById('Fiction').selected = false;
    document.getElementById('Romance').selected = false;
    document.getElementById('Mistery').selected = false;
    document.getElementById('Classic').selected = false;
    document.getElementById('Other').selected = false;
    console.log(book.type)
    document.getElementById(book.type).selected = true;
    async function submit(e){
        e.preventDefault();
        let data = new FormData(e.target);
        let desc = data.get('description');
        let img = data.get('imageUrl');
        let title = data.get('title');
        let type = data.get('type');
        if(!title||!type||!img||!desc){
            return alert('bad data');
        }
        let result = {
            title:title,
            type:type,
            description:desc,
            imageUrl:img,

        }
        console.log('click');
        await editBook(id,result);
        ctx.page.redirect(`/details/${id}`);
    }
    ctx.navigation();
}