function extract(content) {
    let element = document.getElementById(content);
    const regexp = /(?<=\().+?(?=\))/g
    let arr = element.textContent.matchAll(regexp);
    let[...arrElements] = arr;
    let text = arrElements.join('; ');
    return text;

}