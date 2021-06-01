function solve(nameCity,populationCity,treasuryCity){
    const cityTaxes ={
        name: nameCity,
        population: populationCity,
        treasury: treasuryCity,
        taxRate: 10,
        collectTaxes: function(){this.treasury+=this.population*this.taxRate
        this.treasury = Math.floor(this.treasury)},
        applyGrowth: function(percentage){
            this.population+=this.population*percentage/100;
            population = Math.floor(this.population);

        },
        applyRecession: function(percentage){
            this.treasury -=this.treasury*percentage/100;
            this.treasury = Math.floor(this.treasury);
        }

    }
    return cityTaxes;
}
const city =
solve('Tortuga',
7000,
15000);
city.collectTaxes();
console.log(city.treasury);
city.applyGrowth(5);
console.log(city.population);
 