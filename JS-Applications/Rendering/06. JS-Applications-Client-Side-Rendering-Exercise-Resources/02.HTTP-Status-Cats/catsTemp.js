import { html } from "./node_modules/lit-html/lit-html.js";
import {catTemp} from "./catTemplat.js"
export const catsTemplate= (cats,action)=>html` 
                <ul>
                    ${cats.map(x=>catTemp(x,action))}
                </ul>
`