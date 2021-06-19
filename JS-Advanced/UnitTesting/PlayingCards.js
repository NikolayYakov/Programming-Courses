function solve(card,face){
    let validCard = ['2','3','4','5','6','7','8','9','10','J','Q','K','A'];
    let validFace = ['S','H','D','C'];
    let unicodes = {
        S: '\u2660',
        H: '\u2665',
        D: '\u2666',
        C: '\u2666'
    }
    if(!validCard.includes(card)||!validFace.includes(face)){
        throw new Error('Error');
    }
    return {
        card: card,
        suit: face,
        toString: function(){
            return`${this.card}${unicodes[this.suit]}`;
        }
    }

}
try{
    console.log(solve('A', 'S').toString());
}catch(ex){
    console.log(ex);

}


