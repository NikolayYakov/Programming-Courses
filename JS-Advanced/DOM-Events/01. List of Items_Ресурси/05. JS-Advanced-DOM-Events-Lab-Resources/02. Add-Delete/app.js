function addItem() {
    let list = document.getElementById('items');
    let text = document.getElementById('newItemText');
    let newLi = document.createElement('li');
    newLi.textContent = text.value;
    let deleteLink = document.createElement('a');
    deleteLink.setAttribute("href","#");
    deleteLink.textContent = '[Delete]';
    deleteLink.addEventListener('click',(e)=>{
    e.target.parentElement.remove();
         


    })
    newLi.appendChild(deleteLink);
    list.appendChild(newLi);
    text.value = '';
}