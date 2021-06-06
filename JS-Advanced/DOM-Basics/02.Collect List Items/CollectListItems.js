function extractText() {
    let listElements = document.querySelectorAll('#items li');
    let textBox = document.getElementById('result');
    let result = ''
    for (const element of listElements) {
        result+=element.textContent+'\n';
    }
    textBox.value = result.trim();
     
}