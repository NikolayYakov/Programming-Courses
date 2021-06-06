function solve() {
   document.querySelector('#btnSend').addEventListener('click', onClick);

   function onClick () {
      let info = document.querySelector('textarea');
      let text = info.value.replace('["','').replace('"]','').trim();
      let restorants = text.split('","');
      const city = {

      }
      while(restorants.length>0){
         let restorant = restorants.shift().split(' - ');
         let [restorantName,...workers] = restorant;
         if(!city[restorantName]){
            city[restorantName] = {};

         }
         for(let i =0;i<workers.length;i++){
            let pairs = workers[i].split(', ');
            for(let j = 0;j<pairs.length;j++){
               let [name,salary] = pairs[j].split(' ');
               city[restorantName][name] = Number(salary);
            }
            
         }
         
      }
      let bestSalaryAvr = 0;
      let bestRestorant;
      let count = 0;
      let bestSalary = 0;
      for (const restorant in city) {
         let averageSalary = 0;
         count = Object.keys(city[restorant]).length;
         let localBestSalary = 0;
         for (const worker in city[restorant]) {
           
            averageSalary+=city[restorant][worker];
            if(city[restorant][worker]>localBestSalary){
               localBestSalary = city[restorant][worker];
            }

         }
         averageSalary/=count;
         if(averageSalary>bestSalaryAvr){
            bestSalaryAvr = averageSalary;
            bestRestorant = restorant;
            bestSalary = localBestSalary;
         }
      }
     
      let getResultBestRestorant = document.querySelector('#bestRestaurant p');
      getResultBestRestorant.textContent = `Name: ${bestRestorant} Average Salary: ${bestSalaryAvr.toFixed(2)} Best Salary: ${bestSalary.toFixed(2)}`;
      let sortable = [];
      for (const key in city[bestRestorant]) {
          sortable.push([key,city[bestRestorant][key]]);
      }
      sortable.sort((a,b)=>b[1]-a[1]);
      let bestWorkers = '';
      for (const worker of sortable) {
         bestWorkers+=` Name: ${worker[0]} With Salary: ${worker[1]}`;
      }
      let getResultBestWorkers = document.querySelector('#workers p');
      getResultBestWorkers.textContent = bestWorkers.trim();
      
   }
       
      
      
   
}