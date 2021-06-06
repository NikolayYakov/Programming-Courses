function subtract() {
     let numberOne = document.getElementById('firstNumber');
     let numberTwo = document.getElementById('secondNumber');
     let result = document.getElementById('result');
     let subtraction = Number(numberOne.value)-Number(numberTwo.value);
     result.textContent = subtraction

}