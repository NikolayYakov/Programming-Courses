function solve(){
    const library = {
        hasClima: function(myCar){
            myCar.temp = 21;
            myCar.tempSettings = 12;
            myCar.adjustTemp = function(){
                if(this.temp<this.tempSettings){
                    this.temp++;
                }else if(this.temp>this.tempSettings){
                    this.temp--;
                }

            }
            
        },
        hasAudio: function(myCar){
            myCar.currentTrack = null;
            myCar.nowPlaying = function(){
                 if(this.currentTrack!=null){
                     console.log(`Now playing '${this.currentTrack.name}' by ${this.currentTrack.artist}`);
                    
                 }
            }
        },
        hasParktronic: function(myCar){
            myCar.checkDistance = function(distance){
                if(distance<0.1){
                    console.log('Beep! Beep! Beep!');
                }else if(distance>=0.1&&distance<0.25){
                    console.log('Beep! Beep!')
                }else if(distance>=0.25&&distance<0.5){
                    console.log('Beep!');
                }else{
                    console.log('');
                }


            }
        } 
    }
    return library;
}
const assemblyLine = solve();
const myCar = {
make: 'Toyota',
model: 'Avensis'
};
console.log(myCar);