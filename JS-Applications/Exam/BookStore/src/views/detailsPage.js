import { html } from "../../node_modules/lit-html/lit-html.js"
import {getUserInfo} from '../utility.js'
import {getBookById,delBook} from "../api/data.js"
const temp = (book,id,del)=>html`
<section id="details-page" class="details">
    <div class="book-information">
        <h3>${book.title}</h3>
        <p class="type">Type: ${book.type}</p>
        <p class="img"><img src=${book.imageUrl}></p>
        <div class="actions">
            ${book._ownerId==id?html`<!-- Edit/Delete buttons ( Only for creator of this book )  -->
            <a class="button" href="/edit/${book._id}">Edit</a>
            <a @click= ${del} class="button" href="javascript:void(0)">Delete</a>`:''}
            

            <!-- Bonus -->
            <!-- Like button ( Only for logged-in users, which is not creators of the current book ) -->
            <a class="button" href="#">Like</a>

            <!-- ( for Guests and Users )  -->
            <div class="likes">
                <img class="hearts" src="/images/heart.png">
                <span id="total-likes">Likes: 0</span>
            </div>
            <!-- Bonus -->
        </div>
    </div>
    <div class="book-description">
        <h3>Description:</h3>
        <p>${book.description}</p>
    </div>
</section>
`
export async function detailsPage(ctx){
    let id = ctx.params.id;
    let book = await getBookById(id);
    console.log(book);
    let userId = getUserInfo();
    if(userId){
        ctx.render(temp(book,userId._id,delBtn));
        async function delBtn(){
            await delBook(book._id);
            ctx.page.redirect('/')

        }
    
    }else{
        ctx.render(temp(book));

    }
    ctx.navigation();
}