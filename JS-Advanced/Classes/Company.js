class Company{
    constructor(){
        this.departments = {}; 
    }
    addEmployee(name,salary,position,department){
        if(!name||!position||!department||!salary){
            throw new Error('Invalid input!')
        }else if(salary<0){
            throw new Error('Invalid input!');
        }
        if(!this.departments[department]){
            this.departments[department] = [];
        }
        this.departments[department].push({name:name,salary:salary,position:position});
        return `New employee is hired. Name: ${name}. Position: ${position}`;
        
    }
    bestDepartment(){
        let bestSalary = 0;
        let dep = '';
        for (const key in this.departments) {
            let avrgSalary = 0;
            let count = 0;
            for (const employ of this.departments[key]) {
                avrgSalary+=employ.salary
                count++;
            }
            avrgSalary/=count;
            if(avrgSalary>bestSalary){
                bestSalary = avrgSalary;
                dep = key;
            }
        }
        let result = `Best Department is: ${dep}\nAverage salary: ${bestSalary.toFixed(2)}`;
       
        this.departments[dep].sort((a,b)=>{
            if(b.salary>a.salary){
                return 1;
            }else if(b.salary<a.salary){
                return -1;
            }else{
                if(a.name.localeCompare(b.name)){
                    return -1;
                }else{
                    return +1;
                }
            }
        })
        for (const employ of this.departments[dep]) {
            result+=`\n${employ.name} ${employ.salary} ${employ.position}`;
        }
        return result;
    }
     
}
let c = new Company();
c.addEmployee("Stanimir", 2000, "engineer", "Construction");
c.addEmployee("Pesho", 1500, "electrical engineer", "Construction");
c.addEmployee("Slavi", 500, "dyer", "Construction");
c.addEmployee("Stan", 2000, "architect", "Construction");
c.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing");
c.addEmployee("Pesho", 1000, "graphical designer", "Marketing");
c.addEmployee("Gosho", 1350, "HR", "Human resources");
console.log(c.bestDepartment());
