function loadCommits() {
    let username = document.getElementById('username');
    let repo = document.getElementById('repo');
    let ul = document.getElementById('commits');
    while(ul.childElementCount>0){
        ul.removeChild(ul.children[0]);
    }
    let url = `https://api.github.com/repos/${username.value}/${repo.value}/commits`;
    fetch(url).then(rep=>{
        if(rep.ok){
            return rep.json();
        }else{
            console.log(rep);
            throw new Error(rep.status);
        }
    }).then(text=>{
        for (const element of text) {
            let li = document.createElement('li');
            console.log(element);
            li.textContent = `${element.commit.committer.name}: ${element.commit.message}`;
            ul.appendChild(li);
        }
        
    }).catch(ex=>{
         let li = document.createElement('li');
         li.textContent = ex;
         ul.appendChild(li);
    })
}