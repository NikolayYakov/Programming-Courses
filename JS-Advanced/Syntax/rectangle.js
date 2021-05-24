function solve(size){
    if(size==undefined){
        size = 5;
    }
    
    for(let i = 0;i<size;i++){
        let row = '';
        for(let j=0;j<size;j++){
            if(j===0){
                row+='*';
            }
            else{
                row+=' *';
            }
          
        }
        console.log(row);
    }
}
solve();
