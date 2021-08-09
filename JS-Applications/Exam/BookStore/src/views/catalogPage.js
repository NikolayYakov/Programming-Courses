import { html } from "../../node_modules/lit-html/lit-html.js"
import {getBooks} from "../api/data.js"
const bookTemp = (book)=>html`
       <li class="otherBooks">
            <h3>${book.title}</h3>
            <p>Type: ${book.type}</p>
            <p class="img"><img src=${book.imageUrl}></p>
            <a class="button" href="/details/${book._id}">Details</a>
        </li>
`
const temp =  (books)=>html`
 <section id="dashboard-page" class="dashboard">
    <h1>Dashboard</h1>
    ${books.length==0?html`<p class="no-books">No books in database!</p>`:html`<ul class="other-books-list">${books.map(bookTemp)}</ul>`}
    
</section>
             
`
export async function catalogPage(ctx){
    let books = await getBooks();
    console.log(books);
    ctx.render(temp(books));
    ctx.navigation();
}