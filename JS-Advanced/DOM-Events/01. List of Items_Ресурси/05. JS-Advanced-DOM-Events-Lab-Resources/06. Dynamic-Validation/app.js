function validate() {
     let text  = document.getElementById('email');
     let regex = /^([a-z]+)@[a-z]+\.[a-z]+/g;
     text.addEventListener('change',(e)=>{
        let found =  text.value.match(regex);
        if(!found){
            text.classList.add('error');
        }else{
            text.classList.remove('error');
        }
     })
}