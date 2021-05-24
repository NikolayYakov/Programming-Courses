function solve(number,command1,command2,command3,commmand4,command5){
    let realNumber = Number(number) 
    let commands = [command1,command2,command3,commmand4,command5];
    commands.forEach(element => {
        if(element=='chop'){
            realNumber/=2;
        }
        else if(element=='dice'){
            realNumber = Math.sqrt(realNumber);
        }
        else if(element=='spice'){
            realNumber+=1;
        }
        else if(element=='bake'){
            realNumber*=3;
        }
        else if(element=='fillet'){
            realNumber-=0.20*realNumber;
        }
        console.log(realNumber);

    });
 

}
solve('32', 'chop', 'chop', 'chop', 'chop',
      'chop');
solve('9','dice','spice','chop','bake','fillet');