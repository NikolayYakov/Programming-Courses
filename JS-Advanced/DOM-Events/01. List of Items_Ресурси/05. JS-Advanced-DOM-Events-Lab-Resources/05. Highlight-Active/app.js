function focused() {
     let sections = document.querySelectorAll('input');
    for (const element of sections) {
        element.addEventListener('focus',(e)=>{
            e.target.parentElement.classList.add('focused');
        })
        element.addEventListener('blur',(e)=>{
            e.target.parentElement.classList.remove(('focused'));
        })
    }
}