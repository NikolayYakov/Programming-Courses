function solve() {
     let lectureName = document.querySelector('[name = lecture-name]');
     let lectureData = document.querySelector('[name = lecture-date]');
     let lectureModule = document.querySelector('[name = lecture-module]');
     let addButton = document.querySelector('button');
     let addSection = document.querySelector('.modules');
     let addedModules = [];
     addButton.addEventListener('click',(e)=>{
         e.preventDefault();
         if(lectureName.value == ''||lectureData.value ==''||lectureModule.value=='Select module'){
            return

         }
         let ul = document.createElement('ul');
         let li = document.createElement('li');
         li.classList.add('flex');
         let h4 = document.createElement('h4');
         let arr = lectureData.value.split('-');
         let timeArr = arr[2].split('T');
         h4.textContent = `${lectureName.value} - ${arr[0]}/${arr[1]}/${timeArr[0]} - ${timeArr[1]}`;
         let delButton = document.createElement('button');
         delButton.classList.add('red');
         delButton.textContent = 'Del';
         let h3  =document.createElement('h3');
         h3.textContent = `${lectureModule.value.toUpperCase()}-MODULE`;
         let moduleSection = document.createElement('div');
         let ele = undefined;
         console.log(ul);
         for (const element of addedModules) {
             if(element.textContent==h3.textContent){
                 ele = element;
                 break;
                 
             }
         }
         if(ele){
             moduleSection = ele.parentElement;
             ul = moduleSection.children[1];
             console.log(ul);             
              
              
         }else{
            moduleSection.classList.add('module');
            moduleSection.appendChild(h3);
            addedModules.push(h3);
            moduleSection.appendChild(ul)
            addSection.appendChild(moduleSection);
         } 
         li.appendChild(h4);
         li.appendChild(delButton);
         ul.appendChild(li);
         let lis = [];
         for (const element of ul.childNodes) {
             lis.push(element);
         }
        lis = lis.sort((a,b) => a.children[0].textContent.localeCompare(b.children[0].textContent));
         for(let i = 0;i< lis.length;i++){
             ul.children[i] = lis[i];
         }
         delButton.addEventListener('click',(e)=>{
             ul.removeChild(li);
             console.log(ul.length);
             console.log(ul);
             console.log(addedModules);
             if(!ul.firstChild){
                 addSection.removeChild(moduleSection);
                 let indexx = addedModules.indexOf(h3);
                 addedModules.splice(indexx,1);

             }
             
         })
         
        

     })

      
};