import * as api from './api.js'
api.settings.host = 'http://localhost:3030'
export const login = api.login;
export const register = api.register;
export const logout = api.logout;
export async function getBooks(){
    return await api.get(api.settings.host+'/data/books?sortBy=_createdOn%20desc');
} 
export async function getBookById(id){
    return await api.get(api.settings.host+`/data/books/${id}`);
}
export async function delBook(id){
    return await api.del(api.settings.host+`/data/books/${id}`)
}
export async function createBook(book){
    return await api.post(api.settings.host+'/data/books',book)
}  
export async function getUserPage(id){
    return await api.get(api.settings.host+`/data/books?where=_ownerId%3D%22${id}%22&sortBy=_createdOn%20desc`)
}
export async function editBook(id,book){
    return await api.put(api.settings.host+`/data/books/${id}`,book)
}