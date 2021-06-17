function solution(command){
    if(command=='upvote'){
        this.upvotes+=1;
    }else if(command=='downvote'){
        this.downvotes+=1;
    }else if(command=='score'){
        let result = [];
        let balance = this.upvotes-this.downvotes;
        let sum = this.upvotes+this.downvotes;
        let rating = '';
        if(sum>50){
            let addNumber = Math.ceil(Math.max(this.upvotes,this.downvotes)*25/100);
            let modifiedUpvotes = this.upvotes+addNumber;
            let modifiedDownvotes = this.downvotes+addNumber;
            result.push(modifiedUpvotes);
            result.push(modifiedDownvotes);
        }else{
            result.push(this.upvotes);
            result.push(this.downvotes);
        }
        result.push(balance);
        if(sum<10){
            rating = 'new';
        }
        else if(this.upvotes/sum*100>66){
            rating = 'hot';

        }else if(sum>100&&balance>=0){
            rating = 'controversial';
        }else if(balance<0){
            rating = 'unpopular';
        }else{
            rating = 'new';
        }
        result.push(rating);
        return result;
    }


}
let post = {
    id: '3',
    author: 'emil',
    content: 'wazaaaaa',
    upvotes: 100,
    downvotes: 100
};

solution.call(post, 'upvote');
solution.call(post, 'downvote');
let score = solution.call(post, 'score');
console.log(score);
for(let i =0;i<50;i++){
    solution.call(post, 'downvote');
}
score = solution.call(post, 'score'); 
console.log(score); 
