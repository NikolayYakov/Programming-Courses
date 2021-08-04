import { html } from "../../node_modules/lit-html/lit-html.js"
import {getUserInfo} from '../utility.js'
import {getMemeById,delMeme} from "../api/data.js"
const temp = (meme,id,delBtn)=>html`
         <section id="meme-details">
            <h1>Meme Title: ${meme.title}

            </h1>
            <div class="meme-details">
                <div class="meme-img">
                    <img alt="meme-alt" src=${meme.imageUrl}>
                </div>
                <div class="meme-description">
                    <h2>Meme Description</h2>
                    <p>
                         ${meme.description}
                    </p>

                     ${meme._ownerId==id ? html`
                     <a class="button warning" href="/edit/${meme._id}">Edit</a>
                    <button @click=${delBtn} class="button danger">Delete</button>
                     `:''}

                </div>
            </div>
        </section>
`
export async function detailsPage(ctx){
    let id = ctx.params.id;
    let meme = await getMemeById(id);
    console.log(meme);
    let userId = getUserInfo();
    if(userId){
        ctx.render(temp(meme,userId._id,delBtn));
        async function delBtn(){
            await delMeme(meme._id);
            ctx.page.redirect('/catalog')

        }
    
    }else{
        ctx.render(temp(meme));

    }
    ctx.navigation();
}