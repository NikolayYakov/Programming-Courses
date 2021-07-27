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
    it('when load book is clicked load all the books',async()=>{
        await page.goto('http://localhost:3000/')
        await page.click('#loadBooks');
        await page.waitForSelector('tbody tr td')
        let isVisible = await page.isVisible('tbody tr td');
        assert.isTrue(isVisible);
      
    });
    it('when submited book should be saved',async()=>{
        await page.goto('http://localhost:3000/')
       await page.click('[placeholder="Title..."]');
       await page.fill('[placeholder="Title..."]', 'lord of the rings');
       await page.click('[placeholder="Author..."]');
       await page.fill('[placeholder="Author..."]', 'j.r.r.tolkien');
       await page.click('text=Submit');
       await page.click('#loadBooks');
       const createdBook = await page.$eval('tbody tr:nth-last-child(1) :first-child', (el) => el.textContent.trim());
       const createdAuthor = await page.$eval('tbody tr:nth-last-child(1) :nth-child(2)', (el) => el.textContent.trim())
       assert.equal(createdBook,'lord of the rings');
       assert.equal(createdAuthor,'j.r.r.tolkien');

    })
    it('when edit button is click new form should show and when save is clicked data should be changed',async()=>{
        await page.goto('http://localhost:3000/');
        await page.click('text=LOAD ALL BOOKS');
        await page.click('text=Edit');
        await page.click('text=Edit FORM TITLE AUTHOR Save >> [placeholder="Title..."]');
        await page.click('text=Edit FORM TITLE AUTHOR Save >> [placeholder="Title..."]', 'edited');
        await page.click('text=Edit FORM TITLE AUTHOR Save >> [placeholder="Author..."]');
        await page.fill('text=Edit FORM TITLE AUTHOR Save >> [placeholder="Author..."]', 'edithor');
        await page.click('text=Save');
        await page.click('text=LOAD ALL BOOKS');
        await page.waitForSelector('tbody tr td');
        const firstBook = await page.$eval('tbody tr:first-child :first-child', (el) => el.textContent.trim());
        const firstAuthor = await page.$eval('tbody tr:first-child :nth-child(2)', (el) => el.textContent.trim());
        assert.equal(firstBook,'edited');
        assert.equal(firstAuthor,'edithor')

    })
    it('delete book',async()=>{
            await page.goto('http://localhost:3000/');
            await page.click('text=LOAD ALL BOOKS');
            page.on('dialog', (dialog) => {
                dialog.accept();
            });
            await page.click('tbody tr::nth-child(1) .deleteBtn');
            await page.click('#loadBooks');
            await page.waitForSelector('tbody tr td');
            const delBook = await page.$eval('tbody tr::nth-child(1) :first-child', (el) => el.textContent.trim());
            const delAuthor = await page.$eval('tbody tr::nth-child(1) :nth-child(2)', (el) => el.textContent.trim());
            assert.equal(delBook,'C# Fundamentals');
            assert.equal(delAuthor,'Svetlin Nakov');

    })
    
})