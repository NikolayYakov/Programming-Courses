function solve() {
   let addButtons = document.querySelectorAll('.add-product');
   let textArea = document.querySelector('textarea');
   let set = new Set();
   let totalPrice = 0;
   for (const element of addButtons) {
      element.addEventListener('click',(e)=>{
         let parent = e.target.parentElement.parentElement;
         let details = parent.children[1];
         let product = details.children[0].textContent;
         let price = Number(parent.children[3].textContent);
         textArea.value+= `Added ${product} for ${price.toFixed(2)} to the cart.\n`
         set.add(product);
         totalPrice+=price;
      })
   
   }
   let chechoutButton = document.querySelector('.checkout');
   chechoutButton.addEventListener('click',(e)=>{
      for (const element of addButtons) {
         element.disabled = true;
          
      }
      textArea.value+=`You bought ${Array.from(set).join(', ')} for ${totalPrice.toFixed(2)}.`;
      chechoutButton.disabled = true;

   })
}