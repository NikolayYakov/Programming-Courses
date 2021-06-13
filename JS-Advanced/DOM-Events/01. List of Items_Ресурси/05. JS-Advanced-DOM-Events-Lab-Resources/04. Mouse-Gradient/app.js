function attachGradientEvents() {
     let hoverArea = document.getElementById('gradient');
     let result = document.getElementById('result');
     hoverArea.addEventListener('mousemove',(e)=>{
        let percent =  e.offsetX/(e.target.clientWidth-1);
        percent = Math.trunc(percent*100);
        result.textContent = `${percent}%`;
     })
     hoverArea.addEventListener('mouseout',(e)=>{
         result.textContent = '';
     })
}