function solve() {

   let textAreas = document.querySelectorAll('textarea');
   let buttons = document.querySelectorAll('button');
   let generateTextArea = textAreas[0];
   let showTextArea = textAreas[1];
   let generateButton = buttons[0];
   let buyButton = buttons[1];
   generateButton.addEventListener('click',(e)=>{
    let json = JSON.parse(generateTextArea.value);
    let getTable = document.querySelector('tbody');
    for (const furniture of json) {
      let createTr = document.createElement('tr');
      let createTd = document.createElement('td');
      let createImg = document.createElement('img');
      createImg.setAttribute('src',furniture.img);
      createTd.appendChild(createImg);
      createTr.appendChild(createTd);
      createTd = document.createElement('td');
      let createP = document.createElement('p');
      createP.textContent = furniture.name;
      createTd.appendChild(createP);
      createTr.appendChild(createTd);
      createTd = document.createElement('td');
      createP = document.createElement('p');
      createP.textContent = furniture.price;
      createTd.appendChild(createP);
      createTr.appendChild(createTd);
      createTd = document.createElement('td');
      createP = document.createElement('p');
      createP.textContent = furniture.decFactor;
      createTd.appendChild(createP);
      createTr.appendChild(createTd);;
      createTd = document.createElement('td');
      let createInput = document.createElement('input');
      createInput.setAttribute('type','checkbox');
      createTd.appendChild(createInput);
      createTr.appendChild(createTd);
      getTable.appendChild(createTr);
      
    }
    
   })
   buyButton.addEventListener('click',(e)=>{
     let checkboxes = document.querySelectorAll('tr td:nth-child(5)');
     let totalPrice = 0;
     let names = [];
     let decorationFactor = 0;
     let count = 0;
     for (const checkbox of checkboxes) {
       if(checkbox.children[0].checked){
         let product = checkbox.parentElement;
         let name = product.children[1].textContent;
         let price = Number(product.children[2].textContent);
         let decoration = Number(product.children[3].textContent);
         totalPrice+=price;
         names.push(name);
         count++;
         decorationFactor+= decoration;

       }
     }
     decorationFactor/=count;
     showTextArea.value+=`Bought furniture: ${names.join(', ')}\n`;
     showTextArea.value+=`Total price: ${totalPrice.toFixed(2)}\n`;
     showTextArea.value+=`Average decoration factor: ${decorationFactor}`;

   })


}