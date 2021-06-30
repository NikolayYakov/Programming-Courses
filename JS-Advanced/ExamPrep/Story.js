class Story{
    #likes;
    #comments;
    constructor(title,creator){
        this.title = title;
        this.creator = creator;
        this.#likes = [];
        this.#comments = [];
    }
    get likes(){
        if(this.#likes.length==0){
            return `${this.title} has 0 likes`
        }else if(this.#likes.length==1){
            return `${this.#likes[0]} likes this story!`
        }else{
           return `${this.#likes[0]} and ${this.#likes.length-1} others like this story!`;
        }
    }
    like (username){
        let user = this.#likes.find(a=>a==username);
        if(user){
            throw new Error(`You can't like the same story twice!`);
        }else if(username===this.creator){
            throw new Error(`You can't like your own story!`);
        }else{
            this.#likes.push(username);
            return `${username} liked ${this.title}!`;
        }
    }
    dislike (username){
        let useer = this.#likes.find(a=>a==username);
        if(!useer){
            throw new Error(`You can't dislike this story!`);
        }else{
            let index = this.#likes.indexOf(useer);
            this.#likes.splice(index,1);
            return `${username} disliked ${this.title}`;
        }
    }
    comment (username, content, id){
        let idFind = this.#comments.find(a=>a.Id==id);
        if(!idFind){
            let comm = {Id:this.#comments.length+1, Username:username, Content:content, Replies:[]};
            this.#comments.push(comm);
            return `${username} commented on ${this.title}`;
        }else{
            let repId = Number(`${idFind.Id}.${idFind.Replies.length+1}`);
            let rep = {Id:repId, Username:username, Content:content};
            idFind.Replies.push(rep);
            return `You replied successfully`;
        }

    }
    toString(sortingType){
        if(sortingType=='asc'){
            this.#comments.sort((a,b)=>a.Id-b.Id);
            for (const com of this.#comments) {
                com.Replies.sort((a,b)=>a.Id-b.Id);
            }
        }else if(sortingType=='desc'){
            this.#comments.sort((a,b)=>b.Id-a.Id);
            for (const com of this.#comments) {
                com.Replies.sort((a,b)=>b.Id-a.Id);
            }
        }else if(sortingType=='username'){
            this.#comments.sort((a,b)=>a.Username.localeCompare(b.Username));
            for (const com of this.#comments) {
                com.Replies.sort((a,b)=>a.Username.localeCompare(b.Username));
            }
        }
        let result = ``;
        result+= `Title: ${this.title}\n`;
        result+=`Creator: ${this.creator}\n`;
        result+=`Likes: ${this.#likes.length}\n`
        result+=`Comments:\n`;
        for (const comment of this.#comments) {
            result+=`-- ${comment.Id}. ${comment.Username}: ${comment.Content}\n`;
            for (const rep of comment.Replies) {
                result+=`--- ${rep.Id}. ${rep.Username}: ${rep.Content}\n`;
            }
        }
        return result.trim();
    }
}
try{
    let art = new Story("My Story", "Anny");
     art.like("John")
    art.likes
    //art.dislike("Sally")
    art.like("Ivan")
    art.like("Steven")
    art.likes
    art.comment("Anny", "Some Content");
    art.comment("Ammy", "New Content", 1)
    art.comment("Zane", "Reply", 2)
    art.comment("Jessy", "Nice :)")
    console.log(art.comment("SAmmy", "Reply@", 2));
    
    art.toString('asc');   

    
}catch(ex){
    console.log(ex.message);
}

