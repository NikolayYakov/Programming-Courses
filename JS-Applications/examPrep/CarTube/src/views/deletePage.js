import {delCar} from '../api/data.js'
export async function deletePage(ctx){
    let id = ctx.params.id;
    await delCar(id);
    ctx.page.redirect('/catalog')

}