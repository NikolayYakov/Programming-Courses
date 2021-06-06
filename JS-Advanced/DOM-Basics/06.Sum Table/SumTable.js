function sumTable() {
    let cellElements = document.querySelectorAll('td:nth-child(2)')
    let cellArr = Array.from(cellElements);
    let sum = cellArr.pop();
    let sumNumber = cellArr.reduce((a,n)=>a+Number(n.textContent),0);
    console.log(sumNumber);
    sum.textContent =  sumNumber;

}