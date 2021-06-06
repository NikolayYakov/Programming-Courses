function solve() {
   let text = document.getElementById('input');
   let arr = text.value.split('.');
   arr = arr.filter(t=>t!='');
  console.log(arr);
   count = 1;
  let result = document.getElementById('output');
  let paragraph = document.createElement('p');
   result.appendChild(paragraph);
   for (const element of arr) {
     if(count>3){
       paragraph = document.createElement('p');
       result.appendChild(paragraph);
       count=1;
     }
     count++;
     paragraph.textContent+=element.trim()+'.';
   }

}