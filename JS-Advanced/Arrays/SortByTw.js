function solve(input){
    function sortFunc(a,b){
        if(a.length>b.length){
            return 1;
        }
        else if(b.length>a.length){
            return -1;
        }
        return a.localeCompare(b);
    }
    input.sort(sortFunc)
    for (const str of input) {
        console.log(str);
    }
    
}
solve(['Isacc','Theodor','Jack','Harrison','George']);