const chromium = require('playwright-chromium').chromium;
const assert = require('chai').assert;
let browser;
let page;
describe('test accordeon',function(){
    this.timeout(6000)
    before(async()=>{
        browser = await  chromium.launch();
    })
    after(async()=>{
        await browser.close();
    })
    beforeEach(async()=>{
        page = await browser.newPage()
    })
    afterEach(async ()=>{
        await page.close();
    })
    it('test if titles loaded',async ()=>{
        await page.goto('http://localhost:3000/');
        let titles = await page.$$('span');
        assert.equal(titles.length,4);
        let titleOne = await page.isVisible('text = Scalable Vector Graphics')
        let titleTwo = await page.isVisible('text = Open standard')
        let titleThree = await page.isVisible('text = Unix')
        let titleFour = await page.isVisible('text = ALGOL')

        assert.isTrue(titleOne);
        assert.isTrue(titleTwo);
        assert.isTrue(titleThree);
        assert.isTrue(titleFour);

    })
    it('when clicked extra text should appear', async ()=>{
        await page.goto('http://localhost:3000/');
        await page.click('text=More');
        let extraText = await page.isVisible('.extra');
        assert.isTrue(extraText);

    })
    it('button text should become less',async ()=>{
        await page.goto('http://localhost:3000/')
        await page.click('text=More');
        let button = await page.textContent('#ee9823ab-c3e8-4a14-b998-8c22ec246bd3');
        assert.equal(button,'Less');
    })
    it('when less is clicked text should hide and button should become more',async()=>{
        await page.goto('http://localhost:3000/')
        await page.click('text=More');
        await page.click('text=Less');
        let extra = await page.isVisible('.extra');
        assert.isFalse(extra);
        let button = await page.textContent('#ee9823ab-c3e8-4a14-b998-8c22ec246bd3');
        assert.equal(button,'More');


    })
})