function validate() {
    let submitButton = document.getElementById('submit');
    let username = document.getElementById('username');
    let email = document.getElementById('email');
    let password = document.getElementById('password');
    let passwordConfirm = document.getElementById('confirm-password');
    let isCompanyButton = document.getElementById('company');
    let companyNumber = document.getElementById('companyNumber');
    let companyInfo = document.getElementById('companyInfo');
    let valid = document.getElementById('valid');
   
    submitButton.addEventListener('click',(event)=>{
        event.preventDefault();
        let isTrue = true;
        if(username.value.length>=3&&username.value.length<=20){
            let regex = /^([a-zA-Z0-9]*)$/g;
            let found = username.value.match(regex);
            if(found){
                username.style.borderColor = '';
            }else{
             username.style.borderColor = 'red';
             isTrue = false;
            }

        }else{
            username.style.borderColor = 'red';
            isTrue = false;
             

        }
        if(password.value.length>=5&&password.value.length<=15){
            let regex =  /^\w+$/g;
            let found = password.value.match(regex);
            if(found&&password.value==passwordConfirm.value){
                password.style.borderColor = '';
                passwordConfirm.style.borderColor = '';
                 

            }else{
             password.style.borderColor = 'red';
             passwordConfirm.style.borderColor = 'red';
             isTrue = false;

            }

        }else{
            password.style.borderColor = 'red';
            passwordConfirm.style.borderColor = 'red';
            isTrue = false;

        }
        if(email.value.includes('@')){
            let index = email.value.indexOf('@');
            let sub = email.value.substring(index);
            if(sub.includes('.')){
                email.style.borderColor = '';
                
            }else{
                email.style.borderColor = 'red';
                isTrue = false;
            }
        }else{
            email.style.borderColor = 'red';
            isTrue = false;

        }
        if(isCompanyButton.checked){
            let number = Number(companyNumber.value);
            if(number>=1000&&number<=9999){
                companyNumber.style.borderColor = '';
            }else{
                companyNumber.style.borderColor = 'red';
                isTrue = false;
            }
        }
        if(isTrue==true){
            valid.style.display = 'block';
            console.log(true);
        }else{
            valid.style.display = 'none';
            console.log(false);
            
        }

    })
    isCompanyButton.addEventListener('change',()=>{
        if(isCompanyButton.checked == true){
            companyInfo.style.display = 'block';
             
        }else{
            companyInfo.style.display = 'none';
           
        }
    })
}
