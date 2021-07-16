export function showPost(post){
    let divComment = document.createElement('div');
    divComment.classList.add('comment');
    let divHeader = document.createElement('div');
    divHeader.classList.add('header');
    let img = document.createElement('img');
    img.setAttribute('href','./static/profile.png');
    img.setAttribute('alt','avatar');
    divHeader.appendChild(img);
    let p = document.createElement('p');
    let span = document.createElement('span');
    span.textContent = post.username;
    let text = document.createTextNode(" posted on ");
    let time = document.createElement('time');
    time.textContent = post.time;
    p.appendChild(span);
    p.appendChild(text);
    p.appendChild(time);
    divHeader.appendChild(p);
    let articleP = document.createElement('p');
    articleP.classList.add('post-content');
    articleP.textContent = post.post;
    divHeader.appendChild(articleP);
    divComment.appendChild(divHeader);
    document.querySelector('main').appendChild(divComment);
}