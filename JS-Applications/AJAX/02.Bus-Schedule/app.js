function solve() {
    let baseUrl = 'http://localhost:3030/jsonstore/bus/schedule';
    let info = document.querySelector('.info');
    let departButton = document.getElementById('depart');
    let arriveButton = document.getElementById('arrive');
    let next = 'depot';
    let arriveName = '';

    function depart() {
       fetch(`${baseUrl}/${next}`)
       .then(res=>{
           return res.clone().json().catch(()=>{throw new Error('Error')});
       })
       .then(data=>{
           info.textContent = `Next stop ${data.name}`;
           arriveName = data.name;
           next = data.next;
           departButton.disabled = true;
           arriveButton.disabled = false;

       }).catch(ex=>{
           info.textContent = 'Error';
           departButton.disabled = true;
       });

    }

    function arrive() {
         try{
             info.textContent = `Arriving at ${arriveName}`;
             arriveButton.disabled = true;
             departButton.disabled = false;

         }catch(ex){
             info.textContent = 'Error';
             arriveButton.disabled = true;

         }
    }

    return {
        depart,
        arrive
    };
}
function makeRequest(){
    
}

let result = solve();