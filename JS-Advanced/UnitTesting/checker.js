function solve(obj){
    if(obj.hasOwnProperty('method')){
        if(obj['method']!='GET'&&obj['method']!='POST'&&obj['method']!='DELETE'&&obj['method']!='CONNECT'){
            throw new Error('Invalid request header: Invalid Method');
        }
    }else{
        throw new Error('Invalid request header: Invalid Method');
    }
    if(obj.hasOwnProperty('uri')){
        let reggex = /^(\.*\w\.*)+$/g;
        let found = obj['uri'].match(reggex);
        if(!found){
            throw new Error('Invalid request header: Invalid URI');
        }
    }else{
        throw new Error('Invalid request header: Invalid URI');

    }
    if(obj.hasOwnProperty('version')){
        if(obj['version']!='HTTP/0.9'&&obj['version']!='HTTP/1.0'&&obj['version']!='HTTP/1.1'&&obj['version']!='HTTP/2.0'){
            throw new Error('Invalid request header: Invalid Version');
        }
    }else{
        throw new Error('Invalid request header: Invalid Version');
    }
    if(obj.hasOwnProperty('message')){
        if(obj['message'].includes('>')||obj['message'].includes('<')||obj['message'].includes('\\')||obj['message'].includes('&')||obj['message'].includes('\'')||obj['message'].includes('\"')){
           throw new Error('Invalid request header: Invalid Message');

        }
    }else{
        throw new Error('Invalid request header: Invalid Message');

     }
    return obj;
}
try{
    console.log(solve({
        method: 'GET',
        uri: 'sda.asd',
        version: 'HTTP/1.1',
        message: '\\'
      }
      ));
}catch(ex){
    console.log(ex.message);
}
 