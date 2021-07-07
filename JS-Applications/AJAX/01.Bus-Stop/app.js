function getInfo() {
     let stopId = document.getElementById('stopId');
     let stopName = document.getElementById('stopName');
     let buses = document.getElementById('buses');
     while(buses.childElementCount>0){
         buses.removeChild(buses.children[0]);
     }
     let url = `http://localhost:3030/jsonstore/bus/businfo/${stopId.value}`;
     fetch(url)
     .then(res=>{
         if(res.ok&&stopId.value){
             return res.clone().json().catch(() => res.text());
         }else{
             throw new Error('Error');
         }
     })
     .then(data=>{
        if(!data){
            throw new Error('Error');
        }
        stopName.textContent = data.name
        for (const key in data.buses) {
             let li = document.createElement('li');
             li.textContent = `Bus ${key} arrives in ${data.buses[key]} minutes`;
             buses.appendChild(li);
        }


     }).catch(ex=>{
         stopName.textContent = ex.message;
     })
}