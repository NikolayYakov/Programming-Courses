import { html } from "../../node_modules/lit-html/lit-html.js"
import {getUserPage} from '../api/data.js'
import {getUserInfo} from '../utility.js'

const memesTemp = (meme) =>html`                
                <div class="user-meme">
                    <p class="user-meme-title">${meme.title}</p>
                    <img class="userProfileImage" alt="meme-img" src=${meme.imageUrl}>
                    <a class="button" href="/details/${meme._id}">Details</a>
                </div>
`

const temp = (username,email,gender,count,memes)=>html`
         <section id="user-profile-page" class="user-profile">
            <article class="user-info">
                <img id="user-avatar-url" alt="user-profile" src="/images/${gender=='male'?'male':'female'}.png">
                <div class="user-content">
                    <p>Username: ${username}</p>
                    <p>Email: ${email}</p>
                    <p>My memes count: ${count}</p>
                </div>
            </article>
            <h1 id="user-listings-title">User Memes</h1>
            <div class="user-meme-listings">
                ${count>0?memes.map(memesTemp):html`<p class="no-memes">No memes in database.</p>`}
            </div>
        </section>
`
export async function profilePage(ctx){
    let id = getUserInfo()._id;
    let username = getUserInfo().username;
    let email = getUserInfo().email;
    let gender = getUserInfo().gender;
    console.log(getUserInfo());
    let userMemes = await getUserPage(id);
    let count = userMemes.length;
    ctx.render(temp(username,email,gender,count,userMemes))
    ctx.navigation();
}