function solve(x1,y1,x2,y2){
    let first = Math.sqrt(x1*x1+y1*y2)
    function distance(x1,y1,x2,y2){
        let distance = x1-x2;
        let distance2 = y1-y2;
        return Math.sqrt(distance*distance+distance2*distance2);
    }
    if(Number.isInteger(distance(x1,y1,0,0))){
        console.log(`{${x1}, ${y1}} to {0, 0} is valid`);
    }
    else{
        console.log(`{${x1}, ${y1}} to {0, 0} is invalid`);

    }
    if(Number.isInteger(distance(x2,y2,0,0))){
        console.log(`{${x2}, ${y2}} to {0, 0} is valid`);
    }
    else{
        console.log(`{${x2}, ${y2}} to {0, 0} is invalid`);

    }if(Number.isInteger(distance(x1,y1,x2,y2))){
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
    }
    else{
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);

    }
}
solve(2, 1, 1, 1);
