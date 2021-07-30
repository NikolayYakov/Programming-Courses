import { html } from "./node_modules/lit-html/lit-html.js";
import {townTemplate} from './townTemplate.js'
export const townsTemplate = (towns)=>html`
<ul>
    ${towns.map(townTemplate)}
</ul>
 
`