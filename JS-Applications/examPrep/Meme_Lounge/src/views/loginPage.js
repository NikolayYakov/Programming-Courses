import { html } from "../../node_modules/lit-html/lit-html.js"
import page from "../../node_modules/page/page.mjs"

import { login } from "../api/data.js";
const temp = (onSubmit)=>html`
       <section id="login">
            <form @submit = ${onSubmit} id="login-form">
                <div class="container">
                    <h1>Login</h1>
                    <label for="email">Email</label>
                    <input id="email" placeholder="Enter Email" name="email" type="text">
                    <label for="password">Password</label>
                    <input id="password" type="password" placeholder="Enter Password" name="password">
                    <input type="submit" class="registerbtn button" value="Login">
                    <div class="container signin">
                        <p>Dont have an account?<a href="/register">Sign up</a>.</p>
                    </div>
                </div>
            </form>
        </section>
`
export async function loginPage(ctx){
    ctx.render(temp(onSubmit));
        async function onSubmit(e){
        e.preventDefault();
        let formData = new FormData(e.target);
        let username = formData.get('email');
        let password = formData.get('password');
        await login(username,password);
        page.redirect('/catalog');
    }
    
}
