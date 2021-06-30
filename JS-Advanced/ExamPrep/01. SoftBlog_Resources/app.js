function solve(){
   let section = document.querySelector('main section');
   let creator = document.getElementById('creator');
   let title = document.getElementById('title');
   let category = document.getElementById('category');
   let content = document.getElementById('content');
   let createButton = document.querySelector('.create');
   let archive = document.querySelector('.archive-section ol');
   let archived = [];
   createButton.addEventListener('click',(e)=>{
      e.preventDefault();
      let article = document.createElement('article');
      let h1 = document.createElement('h1');
      h1.textContent = title.value;
      article.appendChild(h1);
      let pCategory = document.createElement('p');
      pCategory.textContent = 'Category:';
      let strongCategory = document.createElement('strong');
      strongCategory.textContent =category.value;
      pCategory.appendChild(strongCategory);
      article.appendChild(pCategory);
      let pCreator = document.createElement('p');
      pCreator.textContent = 'Creator:';
      let strongCreator = document.createElement('strong');
      strongCreator.textContent =creator.value;
      pCreator.appendChild(strongCreator);
      article.appendChild(pCreator);
      let pContent = document.createElement('p');
      pContent.textContent = content.value;
      article.appendChild(pContent);
      let div = document.createElement('div');
      div.classList.add('buttons');
      let delButton = document.createElement('button');
      delButton.classList.add('btn');
      delButton.classList.add('delete');
      delButton.textContent = 'Delete';
      let archButton = document.createElement('button');
      archButton.classList.add('btn');
      archButton.classList.add('archive');
      archButton.textContent = 'Archive';
      div.appendChild(delButton);
      div.appendChild(archButton);
      article.appendChild(div);
      section.appendChild(article);
      delButton.addEventListener('click',()=>{
         section.removeChild(article);
      })
      archButton.addEventListener('click',()=>{
         section.removeChild(article);
         let li = document.createElement('li');
         archive.appendChild(li);
         archived.push(h1.textContent);
         archived.sort((a,b)=>a.localeCompare(b));
         console.log(archived);
         for(let i = 0;i<archived.length;i++){
            archive.children[i].textContent = archived[i];
         }

      })
      
   })
  }


