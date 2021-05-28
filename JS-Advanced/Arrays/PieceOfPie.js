function solve(input,begginig,ending){
    let startIndex = input.indexOf(begginig);
    let endIndex = input.indexOf(ending);
    let result = input.slice(startIndex,endIndex+1);
    return result;
}
let result = solve(['Pumpkin Pie',
    'Key Lime Pie',
    'Cherry Pie',
    'Lemon Meringue Pie',
    'Sugar Cream Pie'],
    'Key Lime Pie',
    'Lemon Meringue Pie');
console.log(result);
