function calc() {
      let numberOneBox = document.getElementById('num1');
      let numberTwoBox = document.getElementById('num2');
      let resultBox = document.getElementById('sum');
      let sum = Number(numberOneBox.value)+Number(numberTwoBox.value);
      resultBox.value = sum;

}
