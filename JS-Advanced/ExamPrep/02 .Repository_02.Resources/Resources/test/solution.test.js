let { Repository } = require("../solution.js");
let assert = require('chai').assert;
describe("Tests …", function () {
    describe("Repository", function () {
        it("create", function () {
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"
            };
            let rep = new Repository(properties);
            assert.equal(rep.props,properties);
            assert.deepEqual(new Map(),rep.data)
        });
        it('should return count',()=>{
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"
            };
            let rep = new Repository(properties);
            assert.equal(rep.count,0);
        })
    });
    // TODO: …
});
