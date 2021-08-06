import { html } from "../../node_modules/lit-html/lit-html.js"

import { login } from "../api/data.js";
const temp = (onSubmit)=>html`
<section id="login">
    <div class="container">
        <form @submit = ${onSubmit} id="login-form" action="#" method="post">
            <h1>Login</h1>
            <p>Please enter your credentials.</p>
            <hr>

            <p>Username</p>
            <input placeholder="Enter Username" name="username" type="text">

            <p>Password</p>
            <input type="password" placeholder="Enter Password" name="password">
            <input type="submit" class="registerbtn" value="Login">
        </form>
        <div class="signin">
            <p>Dont have an account?
                <a href="/register">Sign up</a>.
            </p>
        </div>
    </div>
</section>
`
export async function loginPage(ctx){
    ctx.render(temp(onSubmit));
        async function onSubmit(e){
        e.preventDefault();
        let formData = new FormData(e.target);
        let username = formData.get('username');
        let password = formData.get('password');
        if(!password||!username){
            return alert('full the input');
        }
        await login(username,password);
        ctx.page.redirect('/catalog');
    }
    
}