function solve(worker){
    if(worker.dizziness === true){
        worker.levelOfHydrated+=worker.weight*worker.experience*0.1;
        worker.dizziness = false;
    }
    return worker;
}
let worker = solve( { weight: 120,
    experience: 20,
    levelOfHydrated: 200,
    dizziness: true });
    console.log(worker);