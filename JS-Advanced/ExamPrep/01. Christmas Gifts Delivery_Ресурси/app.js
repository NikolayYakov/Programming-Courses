function solution() {
     let name = document.querySelector('.card div input');
     let addButton = document.querySelector('.card div button');
     let ulLists = document.querySelectorAll('ul');
     let listGifts = ulLists[0];
     let sendGifts = ulLists[1];
     let discardedGifts = ulLists[2];
     let giftsSort = [];
     addButton.addEventListener('click',()=>{
          let li = document.createElement('li');
          li.textContent = name.value;
          li.classList.add('gift');
          let sendButton = document.createElement('button');
          let discardButton = document.createElement('button');
          sendButton.setAttribute('id','sendButton');
          discardButton.setAttribute('id','discardButton');
          sendButton.textContent = 'Send';
          discardButton.textContent = 'Discard';
          li.appendChild(sendButton);
          li.appendChild(discardButton);
          giftsSort.push(li);
          giftsSort.sort((a,b)=>a.textContent.localeCompare(b.textContent));
          for (const gift of giftsSort) {
              listGifts.appendChild(gift);
          }
          name.value = '';
          sendButton.addEventListener('click',(e)=>{
              let parent = e.target.parentNode;
              let sendLi = document.createElement('li');
              let sendE = parent.children[0];
              let discardE = parent.children[1];
              let index = giftsSort.indexOf(parent);
              giftsSort.splice(index,1);
              parent.removeChild(sendE);
              parent.removeChild(discardE);
              sendLi.textContent = parent.textContent;
              listGifts.removeChild(parent);
              sendGifts.appendChild(sendLi);
                
          })
          discardButton.addEventListener('click',(e)=>{
            let parent = e.target.parentNode;
            let discardLi = document.createElement('li');
            let sendE = parent.children[0];
            let discardE = parent.children[1];
            let index = giftsSort.indexOf(parent);
            giftsSort.splice(index,1);
            parent.removeChild(sendE);
            parent.removeChild(discardE);
            discardLi.textContent = parent.textContent;
            listGifts.removeChild(parent);
            discardedGifts.appendChild(discardLi);
          })


     })

}