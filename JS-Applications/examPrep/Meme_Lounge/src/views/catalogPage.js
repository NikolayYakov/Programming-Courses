import { html } from "../../node_modules/lit-html/lit-html.js"
import {getMemes} from "../api/data.js"
const memeTemp = (meme)=>html`
        <div id="memes">
				<!-- Display : All memes in database ( If any ) -->
                <div class="meme">
                    <div class="card">
                        <div class="info">
                            <p class="meme-title">${meme.title}</p>
                            <img class="meme-image" alt="meme-img" src=${meme.imageUrl}>
                        </div>
                        <div id="data-buttons">
                            <a class="button" href="/details/${meme._id}">Details</a>
                        </div>
                    </div>
                </div> 
`
const temp =  (memes)=>html`
         <section id="meme-feed">
            <h1>All Memes</h1>
            <div id="memes">
                ${memes.length==0 ? html`<p class="no-memes">No memes in database.</p>`:memes.map(memeTemp)}
			</div>
        </section>
             
`
export async function catalogPage(ctx){
    let memes = await getMemes();
    console.log(memes);
    ctx.render(temp(memes));
    ctx.navigation();
}