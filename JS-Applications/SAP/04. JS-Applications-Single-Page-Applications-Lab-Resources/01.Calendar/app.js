import {monthView,showYears} from './yearCalendat.js'
import {seeDates,returnToMonths} from './monthView.js'
function hideEverything(){
    let months = document.querySelectorAll('.monthCalendar');
    let dates = document.querySelectorAll('.daysCalendar');
    for (const calendar of months) {
        calendar.style.display = "none";
    }
    for (const calendar of dates) {
        calendar.style.display = "none";
    }
}
hideEverything();
monthView();
showYears();
seeDates()
returnToMonths();