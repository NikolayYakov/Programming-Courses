const rgbToHexColor  = require('../rgbToHex');
let assert = require('chai').assert;
describe('tests',()=>{
    it('should return false if  values are invalid',()=>{
        let red = -1;
        let green = -1;
        let blue = -1;
        assert.equal(rgbToHexColor(red,1,1),undefined);
        assert.equal(rgbToHexColor(1,green,1),undefined);
        assert.equal(rgbToHexColor(1,1,blue),undefined);
        assert.equal(rgbToHexColor(red,green,blue),undefined);
        red = 'da';
        green = [];
        blue = {};
        assert.equal(rgbToHexColor(red,1,1),undefined);
        assert.equal(rgbToHexColor(1,green,1),undefined);
        assert.equal(rgbToHexColor(1,1,blue),undefined);
        red = 256;
        green = 300;
        blue = 1000;
        assert.equal(rgbToHexColor(red,1,1),undefined);
        assert.equal(rgbToHexColor(1,green,1),undefined);
        assert.equal(rgbToHexColor(1,1,blue),undefined);
        red = 1.132;
        green = 30.1231;
        blue = 10.1231;
        assert.equal(rgbToHexColor(red,1,1),undefined);
        assert.equal(rgbToHexColor(1,green,1),undefined);
        assert.equal(rgbToHexColor(1,1,blue),undefined);
    

    })
    it('Should return string when values are correct',()=>{
        let red = 170;
        let blue = 160;
        let green = 150;
        let value = "#" +
        ("0" + red.toString(16).toUpperCase()).slice(-2) +
        ("0" + green.toString(16).toUpperCase()).slice(-2) +
        ("0" + blue.toString(16).toUpperCase()).slice(-2);
        assert.equal(rgbToHexColor(red,green,blue),value);
        red = 0;
        blue = 0;
        green = 0;
        value = "#" +
        ("0" + red.toString(16).toUpperCase()).slice(-2) +
        ("0" + green.toString(16).toUpperCase()).slice(-2) +
        ("0" + blue.toString(16).toUpperCase()).slice(-2);
        assert.equal(rgbToHexColor(red,green,blue),value);
        red = 255;
        blue = 255;
        green = 255;
        value = "#" +
        ("0" + red.toString(16).toUpperCase()).slice(-2) +
        ("0" + green.toString(16).toUpperCase()).slice(-2) +
        ("0" + blue.toString(16).toUpperCase()).slice(-2);
        assert.equal(rgbToHexColor(red,green,blue),value);
    })
    
})