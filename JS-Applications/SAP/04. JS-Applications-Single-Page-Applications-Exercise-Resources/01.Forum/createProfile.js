import {showPost} from './postView.js'
export async function createProfile(title,username,post){
       let profile = await (await fetch('http://localhost:3030/jsonstore/collections/myboard/posts',{
           method: 'POST',
           headers: {'Content-Type':'application/json'},
           body: JSON.stringify({
               title,
               username,
               post,
               time: new Date().toLocaleString()

           })
       })).json()
}
export async function getAllPosts(){
    let posts = await (await fetch('http://localhost:3030/jsonstore/collections/myboard/posts')).json();
    let mainDivd = document.querySelector('.topic-container');
    while(mainDivd.childElementCount>0){
        mainDivd.removeChild(mainDivd.children[0]);
    }
    for (const post in posts) {
        console.log(post);
        let divWrapper = document.createElement('div');
        divWrapper.classList.add('topic-name-wrapper');
        let divTopic = document.createElement('div');
        divTopic.classList.add('topic-name');
        let a = document.createElement('a');
        a.setAttribute('href','#');
        a.classList.add('normal');
        let h2 = document.createElement('h2');
        h2.textContent = posts[post].title;
        a.appendChild(h2);
        divTopic.appendChild(a);
        let divColoms = document.createElement('div');
        divColoms.classList.add('columns');
        let div = document.createElement('div');
        let p = document.createElement('p');
        p.textContent = 'Date:';
        let time = document.createElement('time');
        time.textContent = posts[post].time;
        p.appendChild(time);
        div.appendChild(p);
        let divUser = document.createElement('div');
        divUser.classList.add('nick-name');
        let pUser = document.createElement('p');
        pUser.textContent = 'Username: ';
        let span = document.createElement('span');
        span.textContent = posts[post].username;
        pUser.appendChild(span);
        divUser.appendChild(pUser);
        div.appendChild(divUser);
        divColoms.appendChild(div);
        divTopic.appendChild(divColoms);
        divWrapper.appendChild(divTopic);
        mainDivd.appendChild(divWrapper);
        a.addEventListener('click',(e)=>{
            mainDivd.style.display = 'none';
            showPost(posts[post]);
            document.querySelector('.new-topic-border').style.display = 'none';
            
        })


    }
    

}