function solve(area,vol,input){
    let json = JSON.parse(input);
    let arr = [];
    for (const obj of json) {
      let areaObj = area.call(obj);
      let volumeObj = vol.call(obj);
      let result = {
          area: areaObj,
          volume: volumeObj
      }
      arr.push(result);

    }
 return arr;
}
function area() {
    return Math.abs(this.x * this.y);
};
function vol() {
    return Math.abs(this.x * this.y * this.z);
};
console.log(solve(area,vol,'[{"x":"1","y":"2","z":"10"},{"x":"7","y":"7","z":"10"},{"x":"5","y":"2","z":"10"}]'));
