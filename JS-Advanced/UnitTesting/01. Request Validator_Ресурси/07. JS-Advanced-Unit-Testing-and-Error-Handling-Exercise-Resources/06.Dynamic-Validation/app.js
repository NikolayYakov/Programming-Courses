function validate() {
    let getEmailForm = document.getElementById('email');
    getEmailForm.addEventListener('change',()=>{
        let regex = /^([a-z]+@[a-z]+\.[a-z]+)$/g;
        let found = getEmailForm.value.match(regex);

        if(found){
            getEmailForm.classList.remove('error');
             
        }else{
            getEmailForm.classList.add('error');
          
        }
    })
}