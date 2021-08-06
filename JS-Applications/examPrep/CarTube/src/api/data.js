import * as api from './api.js'
api.settings.host = 'http://localhost:3030'
export const login = api.login;
export const register = api.register;
export const logout = api.logout;
export async function getCars(){
    return await api.get(api.settings.host+'/data/cars?sortBy=_createdOn%20desc');
} 
export async function getCarById(id){
    return await api.get(api.settings.host+`/data/cars/${id}`);
}
export async function delCar(id){
    return await api.del(api.settings.host+`/data/cars/${id}`)
}
export async function createCar(car){
    return await api.post(api.settings.host+'/data/cars',car)
}  
export async function getUserPage(id){
    return await api.get(api.settings.host+`/data/cars?where=_ownerId%3D%22${id}%22&sortBy=_createdOn%20desc`)
}
export async function editCar(id,car){
    return await api.put(api.settings.host+`/data/cars/${id}`,car)
}