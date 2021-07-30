import { html } from "./node_modules/lit-html/lit-html.js";
export const contatactTemplate = (contact)=>html`
       <div class="contact card">
            <div>
                <i class="far fa-user-circle gravatar"></i>
            </div>
            <div class="info">
                <h2>Name: ${contact.name}</h2>
                <button @click = ${clicked} class="detailsBtn">Details</button>
                <div class="details" id="${contact.id}">
                    <p>Phone number: ${contact.phoneNumber}</p>
                    <p>Email: ${contact.email}</p>
                </div>
            </div>
        </div>
`
function clicked(e){
   let parent = e.target.parentElement;
   parent.children[2].style.display = 'block';
}