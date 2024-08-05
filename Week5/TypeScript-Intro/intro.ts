console.log("Hello world!");

//This is the syntax for giving a type to a variable
let num:number = 30;
let dog:string = "pancake";

//We have access to all the types we would normally expect, such as strings,
//numbers, booleans, etc. As well as some special types.

//Any: lets us break out of the TS type checking, similar to Var in C#
let result: any = 5;
let uncertainValue: unknown = 10;

//Object types
interface Person {
    name: string;
    age: number;
}

//We can use the interface we do any other type!
let tim: Person = {
    name: "tim",
    age: 32
}

//Classes 
//Blueprints for creating objects with properties and behavior
class Pet{
    //Properties
    name: string;
    //We have the ability to use access modifiers in our TS code
    //If we want to access a Pet's species, we need a Getter now
    private species: string;

    //A class needs atleast one constructor in TS
    constructor(name: string, species: string){
        this.name = name;
        this.species = species;
    }

    //And a class can have methods that do things
    greeting(): void {
        console.log("My name is " + this.name);
    }

    //If I have a private field I need to explicitly 
    public getSpecies(): string {
        return this.species;
    }
}

//Instantiating a new Pet, by calling it's constructor
let bailey = new Pet("Bailey", "Cockapoo");

bailey.greeting();

console.log(bailey.name);
console.log(bailey.getSpecies());

//Union types - a way to have a type checked variable that can be of multiple types
//Type alias - a shorthand way to refer to another type

type ID = string | number;

let baileyID: ID;
baileyID = "bailey";
baileyID = "123456";
//baileyID = true; - the compiler will catch this

let pancakeID: ID;
pancakeID = "pancake";

//Casting 
//Casting allows you to override TypeScripts inferred types 

