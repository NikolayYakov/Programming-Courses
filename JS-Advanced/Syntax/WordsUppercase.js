function solve(text){
    let words = text.split(/\W+/g);
    let filltered = [];
    for(let i =0;i<words.length;i++){
        if(words[i]!==''){
           filltered.push(words[i].toUpperCase()); 

        }
         
        
    }
    text = filltered.join(', ');
    return text;


}
console.log(solve('Hi, how are you?'));