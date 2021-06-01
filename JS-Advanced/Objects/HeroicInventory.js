function solve(input){
    let result = [];
    while(input.length>0){
        const hero = {


        }
        let heroData = input.shift().split(' / ');
        let [name,level,items] = heroData;
        let item = items ? items.split(', '):[];
        hero.name = name;
        hero.level = Number(level);
        hero.items = item;
        result.push(hero);

    }
    console.log(JSON.stringify(result));
}
solve(['Isacc / 25 / Apple, GravityGun',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara'])