import {createProfile,getAllPosts} from './createProfile.js'
function createPost(){
    let url = 'http://localhost:3030/jsonstore/collections/myboard/posts';
    let form = document.querySelector('form');
    form.addEventListener('submit',(e)=>{
        e.preventDefault();
        let formData = new FormData(form);
        if(e.submitter.textContent=='Post'){
            if(!formData.get('topicName')||!formData.get('username')||!formData.get('postText')){
                return;
            }
            createProfile(formData.get('topicName'),formData.get('username'),formData.get('postText'));
            getAllPosts();
            e.target.reset();
        }else{
             e.target.reset();
        }
         
    })
}
createPost();