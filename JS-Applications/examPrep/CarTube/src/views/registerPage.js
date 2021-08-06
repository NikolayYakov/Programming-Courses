import { html } from "../../node_modules/lit-html/lit-html.js"
import page from "../../node_modules/page/page.mjs"

import { register } from "../api/data.js";
const temp = (onSubmit)=>html`
<section id="register">
    <div class="container">
        <form @submit=${onSubmit} id="register-form">
            <h1>Register</h1>
            <p>Please fill in this form to create an account.</p>
            <hr>

            <p>Username</p>
            <input type="text" placeholder="Enter Username" name="username" required>

            <p>Password</p>
            <input type="password" placeholder="Enter Password" name="password" required>

            <p>Repeat Password</p>
            <input type="password" placeholder="Repeat Password" name="repeatPass" required>
            <hr>

            <input type="submit" class="registerbtn" value="Register">
        </form>
        <div class="signin">
            <p>Already have an account?
                <a href="/login">Sign in</a>.
            </p>
        </div>
    </div>
</section>
`
export async function registerPage(ctx){
    ctx.render(temp(onSubmit));
        async function onSubmit(e){
            e.preventDefault();
            let formData = new FormData(e.target);
            let username = formData.get('username').trim();
            let password = formData.get('password').trim();
            let repeatPas = formData.get('repeatPass').trim();
            if(!username||!password||!repeatPas){
                return alert('not good data');
            }
            if(password!=repeatPas){
                return alert('passwords dont match');
            }
            await register (username,password,repeatPas);
            page.redirect('/catalog');
        }
       
    
    
}