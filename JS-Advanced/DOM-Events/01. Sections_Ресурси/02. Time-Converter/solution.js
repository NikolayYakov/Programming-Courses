function attachEventsListeners() {

      let daysButton =document.getElementById('daysBtn');
      let hoursButton =document.getElementById('hoursBtn');
      let minutesButton =document.getElementById('minutesBtn');
      let secondsButton =document.getElementById('secondsBtn');
      let days = document.getElementById('days');
      let hours = document.getElementById('hours');
      let minutes = document.getElementById('minutes');
      let seconds = document.getElementById('seconds');
      daysButton.addEventListener('click',(e)=>{
          hours.value = Number(days.value)*24;
          minutes.value = Number(hours.value)*60;
          seconds.value = Number(minutes.value)*60;
      })
      hoursButton.addEventListener('click',(e)=>{
        days.value =  Number(hours.value)/24;
        minutes.value = Number(hours.value)*60;
        seconds.value = Number(minutes.value)*60;
    })
       minutesButton.addEventListener('click',(e)=>{
        hours.value =  Number(minutes.value)/60;
        days.value = Number(hours.value)/24;
        seconds.value = Number(minutes.value)*60;
    })   
        secondsButton.addEventListener('click',(e)=>{
        minutes.value =  Number(seconds.value)/60;
        hours.value =  Number(minutes.value)/60;
        days.value =  Number(hours.value)/24;
    })
      

}