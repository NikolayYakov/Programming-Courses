import { html } from "./node_modules/lit-html/lit-html.js";
export const temp = (towns)=>html`  
       <ul>
           ${towns.map(x=>html`<li>${x}</li>`)}
       </ul>
`