function solution(){
    let result = '';
    return {
        append: function(text){
            result+=text;
        },
        removeStart: function(n){
            result = result.substring(n,result.length);
            
        },
        removeEnd: function(n){
            result = result.substring(0,result.length-n);
        },
        print: function(){
            console.log(result);
        }



    }
}
let firstZeroTest = solution();
firstZeroTest.append('hello');
firstZeroTest.append('again');
firstZeroTest.removeStart(3);
firstZeroTest.removeEnd(4);
firstZeroTest.print();
