window.addEventListener('load', solution);

function solution() {
  
   let name = document.getElementById('fname');
   let email = document.getElementById('email');
   let phone = document.getElementById('phone');
   let addres = document.getElementById('address');
   let code = document.getElementById('code');
   let submitButton = document.getElementById('submitBTN');
   let ul = document.getElementById('infoPreview');
   let editButton = document.getElementById('editBTN');
   let contButton = document.getElementById('continueBTN')
   let data = [];
   let block = document.getElementById('block')
   submitButton.addEventListener('click',()=>{
       if(!name.value.trim()||!email.value.trim()){
         return;
       }
       data[0] = name.value.trim();
       data[1] = email.value.trim();
       data[2] = phone.value.trim();
       data[3] = addres.value.trim();
       data[4] = code.value.trim();
       ul.appendChild(document.createElement('li'));
       ul.appendChild(document.createElement('li'));
       ul.children[0].textContent = `Full Name: ${name.value.trim()}`;
       ul.children[1].textContent = `Email: ${email.value.trim()}`;
       if(data[2]){
        ul.appendChild(document.createElement('li'));
        ul.children[ul.childElementCount-1].textContent = `Phone Number: ${data[2]}`;
       }if(data[3]){
        ul.appendChild(document.createElement('li'));
        ul.children[ul.childElementCount-1].textContent = `Address: ${data[3]}`;
       }if(data[4]){
        ul.appendChild(document.createElement('li'));
        ul.children[ul.childElementCount-1].textContent = `Postal Code: ${data[4]}`;
       }
      
       submitButton.disabled = true;
       editButton.disabled = false;
       contButton.disabled = false;
       name.value = '';
       email.value = '';
       phone.value ='';
       addres.value = '';
       code.value = '';
       

   })
   editButton.addEventListener('click',()=>{
    name.value = data[0];
    email.value = data[1];
    phone.value = data[2];
    addres.value =  data[3];
    code.value = data[4];
    while(ul.childElementCount>0){
      ul.removeChild(ul.children[0]);
    }
    submitButton.disabled = false;
    editButton.disabled = true;
    contButton.disabled = true;
  })
   contButton.addEventListener('click',()=>{
    while(block.childElementCount>0){
      block.removeChild(block.children[0]);
    }
    let h3 = document.createElement('h3');
    h3.textContent = 'Thank you for your reservation!';
    block.appendChild(h3);
     
  })

}
