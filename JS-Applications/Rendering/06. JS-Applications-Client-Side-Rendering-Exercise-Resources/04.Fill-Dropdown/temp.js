import { html } from "./node_modules/lit-html/lit-html.js";
export const temp = (city)=>html`
       <option value=${city._id}>${city.text}</option>
`