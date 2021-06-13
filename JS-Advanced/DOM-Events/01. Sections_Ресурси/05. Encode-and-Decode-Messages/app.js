function encodeAndDecodeMessages() {
    let textAreas = document.querySelectorAll('textarea');
    let buttons = document.querySelectorAll('button');
    let encodeButton = buttons[0];
    let decodeButton = buttons[1];
    let text  = '';
    encodeButton.addEventListener('click',(e)=>{
        textAreas[1].value = '';
         text = textAreas[0].value;
        for(let i = 0;i<text.length;i++){
           let charCode = text.charCodeAt(i);
           charCode++;
           textAreas[1].value+=String.fromCharCode(charCode);
        }
        textAreas[0].value = ''
    })
    decodeButton.addEventListener('click',(e)=>{
        textAreas[1].value = text;

    })
    
}