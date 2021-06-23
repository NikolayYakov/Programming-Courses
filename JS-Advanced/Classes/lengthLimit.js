class Stringer{
    constructor(innerString ,innerLength){
        this.innerString = innerString;
        this.innerLength = innerLength;

    }
    increase(num){
        this.innerLength+= num;
    }
    decrease(num){
        if(this.innerLength<num){
            this.innerLength = 0;
        }else{
            this.innerLength-=num;
        }
    }
    toString(){
        let result = this.innerString;
        if(this.innerLength<this.innerString.length){
            let remove = this.innerString.substring(this.innerLength);
            result = this.innerString.replace(remove,'...');
        }
        return result;
    }
}
let test = new Stringer("Test", 5);
console.log(test.toString()); // Test

test.decrease(3);
console.log(test.toString()); // Te...

test.decrease(5);
console.log(test.toString()); // ...

test.increase(4); 
console.log(test.toString()); // Test
