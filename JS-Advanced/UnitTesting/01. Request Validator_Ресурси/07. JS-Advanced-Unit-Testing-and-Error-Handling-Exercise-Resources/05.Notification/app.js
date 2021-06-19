function notify(message) {
  console.log('todo')
   let getDiv = document.getElementById('notification');
   getDiv.textContent = message;
   getDiv.style.display = 'block';
   getDiv.addEventListener('click',()=>{
     getDiv.style.display = 'none';
   })
}