let form = document.getElementById('form');
let table = document.getElementById('results');
form.addEventListener('submit',(e)=>{
    e.preventDefault();
    create();
})
async function create(){
    let dataForm = new FormData(form);
    if(dataForm.get('firstName')&&dataForm.get('lastName')&&dataForm.get('facultyNumber')&&dataForm.get('grade')){
        let create = await fetch('http://localhost:3030/jsonstore/collections/students',{
            method: 'POST',
            headers: {'content-Type':'application/json'},
            body:JSON.stringify({
                firstName: dataForm.get('firstName'),
                lastName: dataForm.get('lastName'),
                facultyNumber: dataForm.get('facultyNumber'),
                grade: Number(dataForm.get('grade')),
            })
        })
        

    }
    let studets = await (await fetch('http://localhost:3030/jsonstore/collections/students')).json();
    while(table.childElementCount>1){
        table.removeChild(table.children[table.childElementCount-1]);
    }
    let body = document.createElement('tbody');
    for (const key in studets) {
         let tr = document.createElement('tr');
         let tdFirstName = document.createElement('td');
         tdFirstName.textContent = studets[key].firstName;
         let tdLastName = document.createElement('td');
         tdLastName.textContent = studets[key].lastName
         let tdNumber  = document.createElement('td');
         tdNumber.textContent = studets[key].facultyNumber;
         let tdGrade = document.createElement('td');
         tdGrade.textContent = studets[key].grade;
         tr.appendChild(tdFirstName);
         tr.appendChild(tdLastName);
         tr.appendChild(tdNumber);
         tr.appendChild(tdGrade);
         body.appendChild(tr);
         
    }
    table.appendChild(body);
}
