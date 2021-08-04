import { html } from "../../node_modules/lit-html/lit-html.js"
import page from "../../node_modules/page/page.mjs"

import { register } from "../api/data.js";
const temp = (onSubmit)=>html`
        <section id="register">
            <form @submit = ${onSubmit} id="register-form">
                <div class="container">
                    <h1>Register</h1>
                    <label for="username">Username</label>
                    <input id="username" type="text" placeholder="Enter Username" name="username">
                    <label for="email">Email</label>
                    <input id="email" type="text" placeholder="Enter Email" name="email">
                    <label for="password">Password</label>
                    <input id="password" type="password" placeholder="Enter Password" name="password">
                    <label for="repeatPass">Repeat Password</label>
                    <input id="repeatPass" type="password" placeholder="Repeat Password" name="repeatPass">
                    <div class="gender">
                        <input type="radio" name="gender" id="female" value="female">
                        <label for="female">Female</label>
                        <input type="radio" name="gender" id="male" value="male" checked>
                        <label for="male">Male</label>
                    </div>
                    <input type="submit" class="registerbtn button" value="Register">
                    <div class="container signin">
                        <p>Already have an account?<a href="/login">Sign in</a>.</p>
                    </div>
                </div>
            </form>
        </section>
`
export async function registerPage(ctx){
    ctx.render(temp(onSubmit));
        async function onSubmit(e){
            e.preventDefault();
            let formData = new FormData(e.target);
            let email = formData.get('email').trim();
            let password = formData.get('password').trim();
            let username = formData.get('username').trim();
            let repeatPas = formData.get('repeatPass').trim();
            let gender = formData.get('gender').trim();
            if(!email||!username||!gender||!password||!repeatPas){
                return alert('not good data');
            }
            if(password!=repeatPas){
                return alert('passwords dont match');
            }
            await register (email,username,password,repeatPas,gender);
            page.redirect('/catalog');
        }
       
    
    
}