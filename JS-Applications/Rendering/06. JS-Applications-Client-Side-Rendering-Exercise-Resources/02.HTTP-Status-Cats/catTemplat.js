import { cats } from "./catSeeder.js";
import { html } from "./node_modules/lit-html/lit-html.js";
export const catTemp = (cat,action)=>html` 
             <li>
                <img src="./images/cat${cat.id}.jpg" width="250" height="250" alt="Card image cap">
                <div class="info">
                    <button @click=${action} class="showBtn">Show status code</button>
                    <div class="status" style="display: none" id=${cat.id}>
                        <h4>Status Code: ${cat.statusCode}</h4>
                        <p>${cat.statusMessage}</p>
                    </div>
                </div>
            </li>
`
 
