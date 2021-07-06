function solve(){
   let main = document.querySelector('main');
   main.removeChild(main.children[0]);
   let url = 'http://localhost:3030/jsonstore/cookbook/recipes'
   fetch(url)
   .then(res=>res.json())
   .then(text=>{
       console.log(text);
        for (const element in text) {
            let article = document.createElement('article');
            article.classList.add('preview');
            let divTitle = document.createElement('div');
            divTitle.classList.add('title');
            let h2 = document.createElement('h2');
            h2.textContent = text[element].name;
            divTitle.appendChild(h2);
            let divSmall = document.createElement('div');
            divSmall.classList.add('small');
            let img = document.createElement('img');
            img.setAttribute('src',text[element].img);
            divSmall.appendChild(img);
            article.appendChild(divTitle);
            article.appendChild(divSmall);
            main.appendChild(article);
            article.addEventListener('click',()=>{
                while(main.childElementCount>0){
                    main.removeChild(main.children[0]);
                }
                
                let recipeUrl = `http://localhost:3030/jsonstore/cookbook/details/${text[element]._id}`;
                fetch(recipeUrl)
                .then(res=>res.json())
                .then(text=>{
                    console.log(text);
                    let recipeArticle = document.createElement('article');
                    let h2Spect = document.createElement('h2');
                    h2.textContent = text.name;
                    recipeArticle.appendChild(h2Spect);
                    let bandDiv = document.createElement('div');
                    bandDiv.classList.add('band');
                    let thumbDiv = document.createElement('div');
                    thumbDiv.classList.add('thumb');
                    let imgSpec = document.createElement('img');
                    imgSpec.setAttribute('src',text.img);
                    thumbDiv.appendChild(imgSpec);
                    bandDiv.appendChild(thumbDiv);
                    let igrDiv = document.createElement('div');
                    igrDiv.classList.add('ingredients');
                    let h3Igr = document.createElement('h3');
                    h3Igr.textContent = 'Ingredients:';
                    igrDiv.appendChild(h3Igr);
                    let ul = document.createElement('ul');
                    for (const element of text.ingredients) {
                        console.log(element);
                        let li = document.createElement('li');
                        li.textContent = element;
                        ul.appendChild(li);
                    }
                    igrDiv.appendChild(ul);
                    bandDiv.appendChild(igrDiv);
                    let descDiv = document.createElement('div');
                    descDiv.classList.add('description');
                    let prepH3 = document.createElement('h3');
                    prepH3.textContent = 'Preparation:';
                    descDiv.appendChild(prepH3);
                    for (const element of text.steps) {
                        let p = document.createElement('p');
                        p.textContent = element;
                        descDiv.appendChild(p);
                    }
                    recipeArticle.appendChild(bandDiv);
                    recipeArticle.appendChild(descDiv);
                    main.appendChild(recipeArticle);


                })

            })

        }
   })
}
document.addEventListener("DOMContentLoaded", solve);
    
 