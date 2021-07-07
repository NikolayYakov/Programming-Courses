function attachEvents() {
    let location = document.getElementById('location');
    let submitButton = document.getElementById('submit');
    let forecast = document.getElementById('forecast');
    let current = document.getElementById('current');
    let upcoming = document.getElementById('upcoming');
    submitButton.addEventListener('click',(e)=>{
        forecast.style.display = 'block';
        if(current.childElementCount>1){
            current.removeChild(current.children[1]);
        }
        if(upcoming.childElementCount>1){
            upcoming.removeChild(upcoming.children[1]);
        }
        let  dataCode = '';
        solve();
        async function solve(){
            try{
                let resLocations = await (await fetch('http://localhost:3030/jsonstore/forecaster/locations')).json();
                for(let i = 0;i<resLocations.length;i++){
                    if(resLocations[i].name==location.value){
                        dataCode = resLocations[i].code;
                        break;
                    }
                }
                if(dataCode==''){
                    throw new Error('Error');
                }
                let resForcast = await (await fetch(`http://localhost:3030/jsonstore/forecaster/today/${dataCode}`)).json();
                let divForecast = document.createElement('div');
                divForecast.classList.add('forecasts'); 
                let spanSymbol = document.createElement('span');
                console.log(unescape('&#x2614;'));
                switch(resForcast.forecast.condition){
                    case 'Sunny': spanSymbol.textContent = `☀`;break;
                    case 'Partly sunny': spanSymbol.textContent = '⛅';break;
                    case 'OverCast': spanSymbol.textContent = '☁';break;
                    case 'Rain': spanSymbol.textContent = `☂`;break;
                }
                spanSymbol.classList.add('condition');
                spanSymbol.classList.add('symbol');
                divForecast.appendChild(spanSymbol);
                let spanCond = document.createElement('span');
                spanCond.classList.add('condition');
                let spanCity = document.createElement('span');
                spanCity.textContent = resForcast.name;
                spanCity.classList.add('forecast-data');
                let spanDegree = document.createElement('span');
                spanDegree.textContent = `${resForcast.forecast.low}°/${resForcast.forecast.high}°`;
                spanDegree.classList.add('forecast-data');
                let spanState = document.createElement('span');
                spanState.textContent = resForcast.forecast.condition;
                spanState.classList.add('forecast-data');
                spanCond.appendChild(spanCity);
                spanCond.appendChild(spanDegree);
                spanCond.appendChild(spanState);
                divForecast.appendChild(spanCond);
                current.appendChild(divForecast);
                let divForcastUp = document.createElement('div');
                divForcastUp.classList.add('forecast-info');
                
                let resUpcoming = await (await fetch(`http://localhost:3030/jsonstore/forecaster/upcoming/${dataCode}`)).json();
                console.log(resUpcoming);
                for(let i = 0;i<resUpcoming.forecast.length;i++){
                    let spanForeCastUp = document.createElement('span');
                    spanForeCastUp.classList.add('upcoming');
                    let spanUpSymbol = document.createElement('span');
                    spanUpSymbol.classList.add('symbol');
                    switch(resUpcoming.forecast[i].condition){
                        case 'Sunny': spanUpSymbol.textContent = `☀`;break;
                        case 'Partly sunny': spanUpSymbol.textContent = '⛅';break;
                        case 'Overcast': spanUpSymbol.textContent = '☁';break;
                        case 'Rain': spanUpSymbol.textContent = `☂`;break;
                    }
                    spanForeCastUp.appendChild(spanUpSymbol);
                    let spanComingDegree = document.createElement('span');
                    spanComingDegree.textContent = `${resUpcoming.forecast[i].low}°/${resUpcoming.forecast[i].high}°`;
                    spanComingDegree.classList.add('forecast-data');
                    spanForeCastUp.appendChild(spanComingDegree);
                    let spanCondUp = document.createElement('span');
                    spanCondUp.textContent = resUpcoming.forecast[i].condition;
                    spanCondUp.classList.add('forecast-data');
                    spanForeCastUp.appendChild(spanCondUp);
                    divForcastUp.appendChild(spanForeCastUp);
                    
                } 
                upcoming.appendChild(divForcastUp);


            }catch(ex){
                let h3Cur = document.createElement('h3');
                h3Cur.textContent = 'Error';
                current.appendChild(h3Cur);
                let h3Up = document.createElement('h3');
                h3Up.textContent = 'Error';
                upcoming.appendChild(h3Up);
            }

        }
        
    })
}

attachEvents();