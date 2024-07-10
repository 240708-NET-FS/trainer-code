# Class Challenge
A class is a blueprint for a datatype. In this challenge, you will be 
    manipulating a class to experiment with how classes work.

1. In the provided Human class: 
    - Create a public variable 'lastName' of type string. Give it a default value of "Smyth".
    - Create a public variable 'firstName' of type string. Give it a default value of "Pat".
    - Create an AboutMe() method that prints the whole name of the human to the console.
        - ex. "My name is Pat Smyth."
2. In Main, create two Human objects. Give the second Human a different firstName and lastName from the default values.
3. Call the AboutMe() method on both Humans.
4. Add two more public member variables to the Human Class. 'eyeColor' (string) and 'age' (int) with no default values.
5. Create a parameterized constructor that requires all four of the values to be used when creating a Human object.
    - You will run into a bug now. I trust you can resolve it.
6. Refactor the AboutMe() method so that if eyecolor and/or age has not been set, it prints out the information that is set.
    - ex. My name is Pat Smyth. My age is 6. (because eyecolor was not set.)
    - ex. My name is Jim Johnson. My age is 56 and my eye color is Brown. (because firstName, lastName, eyecolor, and age had been set)
7. Create three more objects of type Human.
    - Set eyecolor on the first
    - Set age on the second
    - Change/Set all values on the third
8. Call the AboutMe() method on all three new Humans.
9. Create a new Property called Weight using the prop + tab + tab shortcut.
    - add validation to the Weight property such that a weight below 0 and a weight above 400 isn't allowed
    - If an invalid value is inputted to Weight, return false, otherwise, return true.
10. Instantiate another Human:
    - Set the Weight to a valid value and print the Weight to the console.
    - Try to set the Weight to an invalid value. Your program should crash.

## Reference Materials:

- [Why use private variables?](https://softwareengineering.stackexchange.com/questions/143736/why-do-we-need-private-variables)    
- [Access modifiers and me](https://code-maze.com/csharp-basics-access-modifiers/)
