function addItem() {
     let list = document.getElementById('items');
     let text = document.getElementById('newItemText');
     let newLi = document.createElement('li');
     console.log(newLi);
     newLi.textContent = text.value;

     list.appendChild(newLi);
}