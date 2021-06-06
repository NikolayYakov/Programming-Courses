function colorize() {
    let rowElements = document.querySelectorAll('tr');
    let index = 0;
    for (const iterator of rowElements) {
        index++
        if(index%2==0){
            iterator.style.background = 'teal';
        }
      
    }
}