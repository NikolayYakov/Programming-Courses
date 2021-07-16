export function seeDates(){
    let monthsNames = {
        Jan:1,
        Feb:2,
        Mar:3,
        Apr:4,
        May:5,
        Jun:6,
        Jul:7,
        Aug:8,
        Sept:9,
        Oct:10,
        Nov:11,
        Dec:12

    }
    let months = document.querySelectorAll('.monthCalendar .calendar tbody');
    for (const month of months) {
        month.addEventListener('click',(e)=>{
            if(e.target.nodeName=='TD'||e.target.nodeName=='DIV'){
                let year = month.parentElement.children[0].textContent;
                let id = `month-${year}-`;
                if(e.target.nodeName=='DIV'){
                    id+=monthsNames[e.target.textContent];
                }else{
                    id+=monthsNames[e.target.children[0].textContent];
                }

                let getDates = document.getElementById(id);
                getDates.style.display = 'grid';
                month.parentElement.parentElement.style.display = 'none';
            }
        })
    }
}
export function returnToMonths(){
    let months = document.querySelectorAll('.daysCalendar .calendar');
    for (const month of months) {
        month.children[0].addEventListener('click',(e)=>{
            let data  = e.target.textContent.split(' ');
            let id = `year-${data[1]}`;
            console.log(id);
            let year = document.getElementById(id);
            year.style.display = 'grid';
            month.parentElement.style.display = 'none';
            
        })
    }
}