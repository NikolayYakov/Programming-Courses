class Hex {
    constructor(value){
        this.value = value;
    }
    valueOf() {
        return this.value;
    }
    toString(){
        return  `OX${this.value.toString(16)}`;
    }
    plus(number){
        if(typeof number == 'number'){
             return new Hex(this.value+number);
        }else{
            return new Hex(this.value+number.value);
        }
    }
    minus(number){
        if(typeof number == 'number'){
            return new Hex(this.value-number);
       }else{
           return new Hex(this.value-number.value);
       }
    }
    parse(hex){
        return parseInt(hex,16);
    }
}
let FF = new Hex(255);
console.log(FF.toString());
FF.valueOf() + 1 == 256;
let a = new Hex(10);
let b = new Hex(5);
console.log(a.plus(b).toString());
console.log(a.plus(b).toString()==='0xF');
console.log(FF.parse('AAA'));
