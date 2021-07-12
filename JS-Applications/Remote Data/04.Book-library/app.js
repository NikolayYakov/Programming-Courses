function solve(){
    let baseUrl = 'http://localhost:3030/jsonstore/collections/books';
    let loadButton = document.getElementById('loadBooks');
    let form = document.querySelector('form');
    let table = document.querySelector('tbody');
    let isEdit = false;
    let id = '';
    loadButton.addEventListener('click',(e)=>{
        e.preventDefault();
        while(table.childElementCount>0){
            table.removeChild(table.children[0]);
        }
        load();
    })
    async function load(){
        let books = await (await fetch(baseUrl)).json();
        for (const key in books) {
             let tr = document.createElement('tr');
             let bookTd = document.createElement('td');
             bookTd.textContent = books[key].title;
             let authorTd = document.createElement('td');
             authorTd.textContent = books[key].author;
             let buttonsTd = document.createElement('td');
             let editButton = document.createElement('button');
             editButton.textContent = 'Edit';
             let deleteButton = document.createElement('button');
             deleteButton.textContent = 'Delete';
             buttonsTd.appendChild(editButton);
             buttonsTd.appendChild(deleteButton);
             tr.appendChild(bookTd);
             tr.appendChild(authorTd);
             tr.appendChild(buttonsTd);
             table.appendChild(tr);
             deleteButton.addEventListener('click',(e)=>{
                 deleteBook(tr,key);
             })
             editButton.addEventListener('click',()=>{
                 form.children[0].textContent = 'Edit FORM';
                 form.children[5].textContent = 'SAVE';
                 form.children[2].value = books[key].title;
                 form.children[4].value = books[key].author;
                 isEdit = true
                 id = key;
             })

        }

    }
        form.addEventListener('submit',(e)=>{
            e.preventDefault();
            let formData = new FormData(form);
            if(isEdit==true){
                editBook(id,form.children[2].value,form.children[4].value);
                form.children[0].textContent = 'FORM';
                form.children[5].textContent = 'Submit';
                form.children[2].value = '';
                form.children[4].value = '';
                key = '';
                isEdit = false;
            }else{
                create(formData.get('title'),formData.get('author'));
                form.children[2].value = '';
                form.children[4].value = '';
            }
            
            
        })
    
    async function deleteBook(tr,id){
        let del = await (await fetch(`${baseUrl}/${id}`,{
            method: 'DELETE',
            headers: {'Content-type': 'application/json'},
        })).json();
        tr.remove();
    }
    async function editBook(id,title,author){
        let edit = await (await fetch(`${baseUrl}/${id}`,{
            method: 'PUT',
            headers: {'Content-type': 'application/json'},
            body: JSON.stringify({
                title: title,
                author: author,
            })
        })).json();
        loadButton.click();
    }
    async function create(title,author){
        let create = await (await fetch(`${baseUrl}`,{
            method: 'POST',
            headers: {'Content-type': 'application/json'},
            body: JSON.stringify({
                title: title,
                author: author,
            })
        })).json();
        loadButton.click();
    }

}
solve();