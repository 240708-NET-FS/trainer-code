class Character {
    name;
    hp;
    level;

    constructor(name) {
        this.name = name;
        this.hp = 100;
        this.level = 1;
    }

    takeDamage(dmg) {
        this.hp -= dmg;
    }

    speak(message) {
        const args = arguments.length;
        
        switch(args) {
            default:
            case 0:
                return "Hello";
            case 1:
                return message;
        }
    }
}

module.exports = Character;