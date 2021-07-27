let assert = require('chai').assert;
let chromium =  require('playwright-chromium').chromium;
let browser;
let page;
describe('test',function(){
    this.timeout(6000);
    before(async()=>{
        browser = await chromium.launch();
    });
    after(async()=>{
       await browser.close();
    });
    beforeEach(async()=>{
        page = await browser.newPage();
    });
    afterEach(async()=>{
        await page.close();
    })
    it('test if refresh button show all messages',async()=>{
        await page.goto('http://localhost:3000/');
        await page.click('#refresh');
        const messages = await page.$eval('#messages', (el) => el.value.split('\n'));
        assert.equal(messages[0],'Spami: Hello, are you there?');
        assert.equal(messages[1],'Garry: Yep, whats up :?');
        assert.equal(messages[2],'Spami: How are you? Long time no see? :)');
        assert.equal(messages[3],'George: Hello, guys! :))');
        assert.equal(messages[4],'Spami: Hello, George nice to see you! :)))');
        
    }),
    it('test if messages are send correctly',async()=>{
        await page.goto('http://localhost:3000/');
        await page.click('input[type="text"]');
        await page.fill('input[type="text"]', 'nikolay');
        await page.click('#content');
        await page.fill('#content', 'hi guys');
        await page.click('text=Send');
        await page.click('text=Refresh');
        const messages = await page.$eval('#messages', (el) => el.value.split('\n'));
        assert.isTrue(messages.includes('nikolay: hi guys'));

    })
})