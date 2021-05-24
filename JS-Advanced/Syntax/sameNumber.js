function solve(number){
    let text = number.toString();
    let temp = text[0];
    let flag = true;
    let result = 0;
    for(let i =0;i<text.length;i++){
      if(temp!==text[i]){
          flag = false;

      }
      result +=Number(text[i]);

    }
    console.log(flag);
    console.log(result);

}
solve(1234);