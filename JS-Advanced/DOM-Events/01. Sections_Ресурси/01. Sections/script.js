function create(words) {
     let result = document.getElementById('content');
    
    for (const element of words) {
      let createDiv = document.createElement('div');
      let createP = document.createElement('p');
      createP.style.display = "none";
      createP.textContent = element;
      createDiv.appendChild(createP);
      createDiv.addEventListener('click',(e)=>{
         e.target.children[0].style.display = "block";
      })
      result.appendChild(createDiv);

    }
}