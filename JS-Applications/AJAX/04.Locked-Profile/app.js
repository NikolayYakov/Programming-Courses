function lockedProfile() {
    let profile = document.querySelector('.profile');
    let main = document.querySelector('main');
    fetch('http://localhost:3030/jsonstore/advanced/profiles')
    .then(res=>res.json())
    .then(data=>{
        for (const key in data){ 
            let user = createProfile(profile,data[key]);
            main.appendChild(user);
        }
        profile.remove();
    })
    function createProfile(info,data){
        let profile = info.cloneNode(true);
        profile.children[8].value = data.username;
        profile.children[9].children[2].value = data.email;
        profile.children[9].children[4].value = data.email;
        let button = profile.children[10];
        let unlock = profile.children[4];
        button.addEventListener('click',(e)=>{
            if(unlock.checked==true){
                if(button.textContent==='Show more'){
                   profile.children[9].style.display = 'block';
                   button.textContent = 'Hide it';
                }else{
                    profile.children[9].style.display = 'none';
                    button.textContent = 'Show more';
                }
            }

        })
        return profile;
        
    }
}
