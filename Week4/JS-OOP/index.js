const Character = require("./character.js");
const Wizard = require("./wizard.js");

let myChar = new Wizard("Kung", "Fireball");

console.log(myChar)
console.log(myChar.cast())
console.log(myChar.getMp());
console.log(myChar.getSpell());