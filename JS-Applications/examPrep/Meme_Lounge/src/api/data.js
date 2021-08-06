import * as api from './api.js'
api.settings.host = 'http://localhost:3030'
export const login = api.login;
export const register = api.register;
export const logout = api.logout;
export async function getMemes(){
    return await api.get(api.settings.host+'/data/memes?sortBy=_createdOn%20desc');
} 
export async function getMemeById(id){
    return await api.get(api.settings.host+`/data/memes/${id}`);
}
export async function createMeme(title,description,imageUrl){
    return await api.post(api.settings.host+'/data/memes',{title,description,imageUrl})
}  
export async function delMeme(id){
    return await api.del(api.settings.host+`/data/memes/${id}`)
}
export async function editMeme(id,meme){
    return await api.put(api.settings.host+`/data/memes/${id}`,meme)
}
export async function getUserPage(id){
    return await api.get(api.settings.host+`/data/memes?where=_ownerId%3D%22${id}%22&amp;sortBy=_createdOn%20desc`)
}