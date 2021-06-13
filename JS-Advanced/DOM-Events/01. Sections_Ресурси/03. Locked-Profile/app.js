function lockedProfile() {
   let buttons = document.querySelectorAll('button');
   for (const button of buttons) {
       button.addEventListener('click',(e)=>{
           let profile = e.target.parentElement;
           let hidden = profile.children[9]
           if(profile.children[2].checked === false){

               if(button.textContent==='Show more'){
                   hidden.style.display = 'block';
                   button.textContent = 'Hide it';

               }else{
                   hidden.style.display ='none';
                   button.textContent = 'Show more'
               }


           }
       })
   }
}