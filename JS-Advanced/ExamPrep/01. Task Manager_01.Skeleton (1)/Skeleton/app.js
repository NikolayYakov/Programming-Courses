function solve() {
    let task = document.getElementById('task');
    let description = document.getElementById('description');
    let date = document.getElementById('date');
    let sections = document.querySelectorAll('section div');
    let open = sections[3];
    let progres = sections[5];
    let closed = sections[7];
    let addButton = document.getElementById('add');
    addButton.addEventListener('click',(e)=>{
        e.preventDefault();
        if(task.value == ''||description.value==''||date.value==''){
            return;
        }
        let article = document.createElement('article');
        let h3 = document.createElement('h3');
        h3.textContent = task.value;
        article.appendChild(h3);
        let pDescription = document.createElement('p');
        pDescription.textContent = `Description: ${description.value}`;
        article.appendChild(pDescription);
        pDate = document.createElement('p');
        pDate.textContent = `Due Date: ${date.value}`;
        article.appendChild(pDate);
        let div = document.createElement('div');
        div.classList.add('flex');
        let startButton = document.createElement('button');
        startButton.classList.add('green');
        startButton.textContent = 'Start';
        let delButton = document.createElement('button');
        delButton.classList.add('red');
        delButton.textContent = 'Delete';
        div.appendChild(startButton);
        div.appendChild(delButton);
        article.appendChild(div);
        open.appendChild(article);
        delButton.addEventListener('click',(e)=>{
            article.remove();
        })
        startButton.addEventListener('click',(e)=>{
            open.removeChild(article);
            div.removeChild(startButton);
            let finishButton = document.createElement('button');
            finishButton.classList.add('orange');
            finishButton.textContent = 'Finish';
            div.appendChild(finishButton);
            progres.appendChild(article);
            finishButton.addEventListener('click',()=>{
                progres.removeChild(article);
                div.remove();
                closed.appendChild(article);
            })

        })
    })
}