export function monthView(){
    let getYears = document.querySelector('#years table.calendar');
    getYears.addEventListener('click',(e)=>{
        if(e.target.nodeName == 'TD'||e.target.parentElement.nodeName=='TD'){
            let id = 'year-';
            
            if(e.target.nodeName!='TD'){
                id+=e.target.textContent;
            }else{
                id+=e.target.children[0].textContent;
            }
            let month = document.getElementById(id);
            month.style.display= 'grid';
            getYears.style.display = 'none';
        }
    })

}
export function showYears(){
    let getYears = document.querySelector('#years table.calendar');
    let table = document.querySelectorAll('.monthCalendar .calendar');
    for (const calendar of table) {
        calendar.children[0].addEventListener('click',(e)=>{
            e.target.parentElement.parentElement.style.display = 'none';
            getYears.style.display = 'grid';
        })
    }

}
