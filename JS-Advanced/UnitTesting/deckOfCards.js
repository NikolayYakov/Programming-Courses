function solve(cards){
   
    function createCard(card,face){
        let validCard = ['2','3','4','5','6','7','8','9','10','J','Q','K','A'];
        let validFace = ['S','H','D','C'];
        let unicodes = {
            S: '\u2660',
            H: '\u2665',
            D: '\u2666',
            C: '\u2663'
        }
        if(!validCard.includes(card)||!validFace.includes(face)){
            throw new Error(`Invalid card: ${card}${face}`);
            
        }
        return {
            card: card,
            suit: face,
            toString: function(){
                return`${this.card}${unicodes[this.suit]}`;
            }
        }
    
    }
    let result = [];
    try{
        for (const card of cards) {
            let number = card.substring(0,card.length-1);
            let suit = card.substring(card.length-1);
            let final = createCard(number,suit);
            result.push(final.toString());
              
    
        }
        console.log(result.join(' '));  
    }catch(ex){
        console.log(ex.message);

    }
    
     
   
     
    
     
}
 solve(['5S', '3D', 'QD', '1C']);
        
   