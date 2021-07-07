function attachEvents() {
    let loadButton = document.getElementById('btnLoadPosts');
    let section = document.getElementById('posts');
    let viewButton = document.getElementById('btnViewPost')
    let obj = {
        
    }
    loadButton.addEventListener('click',()=>{
        fetch('http://localhost:3030/jsonstore/blog/posts')
        .then(res=>res.json())
        .then(data=>{
            while(section.childElementCount>0){
                section.removeChild(section.children[0]);
            }
            for (const key in data) {
                let option = document.createElement('option');
                option.setAttribute('value',key);
                option.textContent = data[key].title;
                section.appendChild(option);
                obj[key] = {body:data[key].body,title:data[key].title};
            }
        })
          
    })
    viewButton.addEventListener('click',()=>{
        fetch(`http://localhost:3030/jsonstore/blog/comments`)
        .then(res=>res.json())
        .then(data=>{
            let commentsIds = [];
            let flag = false;
            for (const key in data) {
                if(data[key].postId==section.value){
                    commentsIds.push(key);
                    if(flag==false){
                        document.getElementById('post-title').textContent = obj[data[key].postId].title;
                        document.getElementById('post-body').textContent = obj[data[key].postId].body;
                        flag = true;
                    }
                }
            }
            let ul = document.getElementById('post-comments')
            while(ul.childElementCount>0){
                ul.removeChild(ul.children[0]);
            }
            for (const comment of commentsIds) {
                let li = document.createElement('li');
                li.textContent = data[comment].text;
                li.setAttribute('id',data[comment].id);
                ul.appendChild(li);
            }
        })
    })
}

attachEvents();