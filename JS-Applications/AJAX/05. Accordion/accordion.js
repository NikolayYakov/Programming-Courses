function solution() {
    let section = document.getElementById('main');
    async function request(){
        try{
            let title = await (await fetch('http://localhost:3030/jsonstore/advanced/articles/list')).json();
            for (const article of title) {
                let content = await (await fetch(`http://localhost:3030/jsonstore/advanced/articles/details/${article._id}`)).json();
                create(content.title,content.content,content._id);
            }
        }catch(ex){
            console.log(ex);
        }
        
    }
    request();
    function create(title,content,_id){
        console.log(title,_id);
        let divAcordeon = document.createElement('div');
        divAcordeon.classList.add('accordion');
        let divHead = document.createElement('div');
        divHead.classList.add('head');
        let titleSpan = document.createElement('span');
        titleSpan.textContent = title;
        divHead.appendChild(titleSpan);
        let extraButton = document.createElement('button');
        extraButton.setAttribute('id',_id);
        extraButton.classList.add('button');
        extraButton.textContent = 'More';
        divHead.appendChild(extraButton);
        divAcordeon.appendChild(divHead);
        let extraDiv = document.createElement('div');
        extraDiv.classList.add('extra');
        let p = document.createElement('p');
        p.textContent = content;
        extraDiv.appendChild(p);
        divAcordeon.appendChild(extraDiv);
        section.appendChild(divAcordeon);
        extraButton.addEventListener('click',()=>{
            if(extraButton.textContent=='More'){
                extraDiv.style.display = 'block';
                extraButton.textContent = 'Less';
            }else{
                extraDiv.style.display = 'none';
                extraButton.textContent = 'More';
            }
        })

    }
}
document.addEventListener('DOMContentLoaded',solution());