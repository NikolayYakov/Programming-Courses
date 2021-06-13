function deleteByEmail() {
    let text = document.querySelector('input');
    let list = document.querySelectorAll('#customers tbody tr td:nth-child(2)');
    let arr = Array.from(list);
    arr = arr.filter(t=>t.textContent === text.value);
    for (const element of arr) {
        element.parentElement.remove();
    }
    let result = document.getElementById('result');
    if(arr.length===0){
        result.textContent = 'Not found.';
    }else{
        result.textContent = 'Deleted';
    }
   
    
    
}