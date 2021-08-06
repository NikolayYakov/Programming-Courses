import { render } from '../node_modules/lit-html/lit-html.js'
import page from '../node_modules/page/page.mjs'

import * as utility from './utility.js'
import * as api from './api/data.js'
import {homePage} from './views/homePage.js'
import {loginPage} from './views/loginPage.js'
import {registerPage} from './views/registerPage.js'
import {catalogPage} from './views/catalogPage.js'
import {detailsPage} from './views/detailsPage.js'
import {createPage} from './views/createPage.js'
import {deletePage} from './views/deletePage.js'
import {editPage} from './views/editPage.js'
import {profilePage} from './views/profilePage.js'
let main = document.querySelector('main');
let navUser = document.querySelector('#profile');
let navGuest = document.querySelector('#guest');
document.getElementById('logOutBtn').addEventListener('click',logoutFunc);

page('/',middleware,homePage);
page('/login',middleware,loginPage);
page('/register',middleware,registerPage);
page('/catalog',middleware,catalogPage);
page('/details/:id',middleware,detailsPage);
page('/create',middleware,createPage)
page('/delete/:id',middleware,deletePage)
page('/edit/:id',middleware,editPage)
page('/profile',middleware,profilePage)
page.start();
function middleware(ctx,next){
    ctx.render = (content) => render(content,main);
    ctx.navigation = navigation;
    next();
}
function navigation(){
    let user = utility.getUserInfo();
    if(user){
        navUser.style.display = '';
        navGuest.style.display = 'none';
        document.querySelector('#welcome').textContent = `Welcome ${user.username}`;
    }else{
        navUser.style.display = 'none';
        navGuest.style.display = '';
    }
}
async function logoutFunc(){
    await api.logout();
    page.redirect('/');
}