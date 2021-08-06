import {getUserInfo,setUserInfo,clearUserInfo} from '../utility.js'
export const settings = {

}
async function request(url,options){
    try{
        const response = await fetch(url,options)
        if(response.ok===false){
            const err = await response.json();
            throw new error(err.message);
        }
        try{
            const data = await response.json();
            return data;

        }catch(err){
            return response;
        }
    }catch(err){
        console.log(err.message);
        throw err;

    }
    
}
function createOptions(method = 'GET',body){
    const options ={
        method,
        headers:{},

    }
    const user = getUserInfo();
    if(user){
        options.headers['X-Authorization'] = user.accessToken;
    }
    if(body){
        options.headers['Content-Type'] = 'application/json';
        options.body = JSON.stringify(body);
    }
    return options;
}
export async function get(url){
    return await request(url,createOptions());
}
export async function post(url,body){
    return await request(url,createOptions('POST',body));
}
export async function put(url,body){
    return await request(url,createOptions('PUT',body));
}
export async function del(url){
    return await request(url,createOptions('DELETE'));
}
export async function login(username,password){
    let result = await post(settings.host+'/users/login',{username,password})
    setUserInfo(result);
    return result;
}
export async function register(username,password){
    let result = await post(settings.host+'/users/register',{username,password})
    setUserInfo(result);
    return result;

}
export function logout(){
    let result =  get(settings.host+'/users/logout');
    clearUserInfo();
    return result;
}