function solve(){
    const list = {
        listNumbers: [],
        size: 0,
        add: function(element){
            this.listNumbers.push(element);
            this.listNumbers.sort((a,b)=>a-b);
            this.size++

        },
        remove: function(index){
            if(index<this.size&&index>=0){
                this.listNumbers.splice(index,1);
                this.listNumbers.sort((a,b)=>a-b);
                this.size--;
            }

        },
        get: function(index){
            if(index>=0&&index<this.size){
                return this.listNumbers[index]
            }
        }
        
    }
    return list;
}
let list = solve();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1));
list.remove(1);
console.log(list.get(1));