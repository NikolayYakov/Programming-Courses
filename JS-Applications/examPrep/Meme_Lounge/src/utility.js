export function getUserInfo(){
    let user = sessionStorage.getItem('user');
    if(user){
        return JSON.parse(user);
    }
}
export function setUserInfo(user){
    sessionStorage.setItem('user',JSON.stringify(user));
}
export function clearUserInfo(){
    sessionStorage.clear();
}