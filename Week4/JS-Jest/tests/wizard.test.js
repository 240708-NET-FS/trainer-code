const Wizard = require("../wizard.js");
const Character = require("../character.js");

describe('Wizard Tests', () => {
    test('Is instance of Wizard', () => {
        const myChar = new Wizard('Kung', 'Fireball');

        expect(myChar instanceof Wizard).toBe(true);
    });
    test('Is instance of Character', () => {
        const myChar = new Wizard('Kung', 'Fireball');

        expect(myChar instanceof Character).toBe(true);
    });
    test('Mp should be 9 after one spell cast', () => {
        const myChar = new Wizard('Kung', 'Fireball');
        myChar.cast();

        expect(myChar.getMp()).toBe(9);
    });
})