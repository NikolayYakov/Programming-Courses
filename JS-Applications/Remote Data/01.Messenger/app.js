function attachEvents() {
    let messages = document.getElementById('messages');
    let authorText = document.getElementsByName('author');
    let contentText = document.getElementsByName('content');
    let submitButton = document.getElementById('submit');
    let refreshButton = document.getElementById('refresh');
    submitButton.addEventListener('click',(e)=>{
        console.log(authorText[0]);
        fetch('http://localhost:3030/jsonstore/messenger',{
            method: 'POST',
            headers: {'Content-Type':'application/json'},
            body: JSON.stringify({
                author: authorText[0].value, 
                content: contentText[0].value,

            })
        })
        .then(res=>res.json())
        .then(data=>{
            console.log(data);
        })
        .catch(ex=>{
            console.log(ex);
        })
    })
    refreshButton.addEventListener('click',(e)=>{
        messages.value = ''
        fetch('http://localhost:3030/jsonstore/messenger')
        .then(res=>res.json())
        .then(data=>{
            for (const key in data) {
                messages.value+=`${data[key].author}: ${data[key].content}\n`;
            }
            messages.value.trim();
           

        })
        .catch(()=>{
            console.error();
        })
    })

}

attachEvents();