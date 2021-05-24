function solve(steps,footSize,speed){
    let distance = (steps*footSize)/1000;
    let  hours;
    hours = distance/speed;
    let minutes  = hours*60;
    let bonusMinutes = (steps*footSize)/500; 
    minutes+=Math.floor(bonusMinutes);
    let seconds = Math.round(minutes*60);
    hours = Math.floor(seconds/3600).toFixed(0).padStart(2,'0'); 
    seconds -=hours*3600;
    minutes = Math.floor(seconds/60).toFixed(0).padStart(2,'0'); 
    seconds-= minutes*60;
    seconds = seconds.toFixed(0).padStart(2,'0');
    
    console.log(`${hours}:${minutes}:${seconds}`);
}
solve(10564, 0.70, 5.5);