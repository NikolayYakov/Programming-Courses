function attachEvents() {
    let phonebook = document.getElementById('phonebook');
    let loadButton = document.getElementById('btnLoad');
    let person = document.getElementById('person');
    let phone = document.getElementById('phone');
    let createButton = document.getElementById('btnCreate');
    let baseUrl = 'http://localhost:3030/jsonstore/phonebook';
    loadButton.addEventListener('click',(e)=>{
        e.preventDefault();
        load();
    })
    createButton.addEventListener('click',(e)=>{
        e.preventDefault();
        fetch(baseUrl,{
            method: 'POST',
            headers: {'Content-Type':'application/json'},
            body: JSON.stringify({
                person:person.value,
                phone: phone.value,
            })
        })
        .then(()=>{
            load();
        })
    })
    async function load(){
        while(phonebook.childElementCount>0){
            phonebook.removeChild(phonebook.children[0]);
        }
        try{
            let data = await (await fetch(baseUrl)).json();
            for (const key in data) {
               console.log(data);
               let li = document.createElement('li');
               li.textContent = `${data[key].person}: ${data[key].phone}`;
               let deleteButton = document.createElement('button');
               deleteButton.textContent = 'Delete';
               deleteButton.addEventListener('click',(e)=>{
                   fetch(`${baseUrl}/${data[key]._id}`,{
                       method: 'DELETE',
                       headers:{'Content-Type':'application/json'}
                   });
                   li.remove();
               })
               li.appendChild(deleteButton);
               phonebook.appendChild(li);
            }
        }catch(ex){    
            console.log(ex);
        }
    }   
}   

attachEvents();