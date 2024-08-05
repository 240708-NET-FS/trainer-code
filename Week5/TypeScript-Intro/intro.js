console.log("Hello world!");
//This is the syntax for giving a type to a variable
var num = 30;
var dog = "pancake";
//We have access to all the types we would normally expect, such as strings,
//numbers, booleans, etc. As well as some special types.
//Any: lets us break out of the TS type checking, similar to Var in C#
var result = 5;
var uncertainValue = 10;
//We can use the interface we do any other type!
var tim = {
    name: "tim",
    age: 32
};
//Classes 
//Blueprints for creating objects with properties and behavior
var Pet = /** @class */ (function () {
    //A class needs atleast one constructor in TS
    function Pet(name, species) {
        this.name = name;
        this.species = species;
    }
    //And a class can have methods that do things
    Pet.prototype.greeting = function () {
        console.log("My name is " + this.name);
    };
    //If I have a private field I need to explicitly 
    Pet.prototype.getSpecies = function () {
        return this.species;
    };
    return Pet;
}());
//Instantiating a new Pet, by calling it's constructor
var bailey = new Pet("Bailey", "Cockapoo");
bailey.greeting();
console.log(bailey.name);
console.log(bailey.getSpecies());
var baileyID;
baileyID = "bailey";
baileyID = "123456";
//baileyID = true; - the compiler will catch this
var pancakeID;
pancakeID = "pancake";
//Casting 
//Casting allows you to override TypeScripts inferred types 
