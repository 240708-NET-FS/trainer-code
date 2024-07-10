// we can include libraries with USING statements

using System;


// a namespace is is like a file cabinet, that we can store lots of stuff in!
namespace CSharpConcepts
{ // curly-braces


    // a class is made of members
    // these members are called fields and methods
    // fields are variables
    // methods are functions

    class Program  
    {
         //As a language, c# doesn't care about indentations, only line endings and logical blocks.


        // Access modifiers
        // Private - limits access to the class to the class itself
        // public - access is limited to the class and all of its members
        // internal - access is limited to the class and all of its members, but not to the class's static members
        // protected - access is limited to the class and all of its members, but not to the class's static members

        // modifiers are used to control access to members of a class
        // static - limits access to the class to the class itself and the class's static methods


        // (modifier) (return type) (method name) (parameters)
        static void Main(string[] args)
        {
        // Primitive Data Types
            // boolean - true or false
            // char - a single character value 
            // string - a sequence of characters

        // Collections
            // arrays - a collection of items of the same type
            // lists - a collection of items of different types
            // dictionaries - a collection of key/value pairs
            // queues - a first-in, first-out collection of items
            // stacks - a last-in, first-out collection of items

            Console.WriteLine("Hello World!");

            // declaring a variable
            // (type) (variable name) = (value);
            string s = "Hello World";
            s = "Hello CSharp";

            Console.WriteLine(s);

            string s2;
            //initialize the value
            s2 = "Hi there!";

            // numeric data types
            // integer types
            int newint = 10;
            // int (4 byte)
            // byte (1 byte), short (2 byte), long (8 byte)

            // decimal types
            // *double (8 byte)*, float (4 byte)

            // boolean types
            // true or false are keywords
            bool b = true;
            b = false;

            // logical operators
            b = true || false; // OR - if one condition is true, the result is positive/true
            b = true && false; // AND - if both conditions are true, the result is positive/true

            b = !b; // NOT - if the condition is true, the result is false, otherwise true


            // comparison operators
            b = (3 == 3); // equal to, results in a logical true/false (boolean) value
            b = (3 != 3); // not equal to, results in a logical true/false (boolean) value
            b = (3 > 3); // greater than, results in a logical true/false (boolean) value
            b = (3 < 3); // less than, results in a logical true/false (boolean) value
            b = (3 >= 3); // greater than or equal to, results in a logical true/false (boolean) value
            b = (3 <= 3); // less than or equal to, results in a logical true/false (boolean) value



            // control flow
            // conditional statements

            // if 
            // if (condition is true)
            if (newint == 3)
            {
                //take some action, but only if 3 == 3
                // then contine running AFTER the last else block
            }
            // else if (condition is true)
            else if (newint == 4)
            {
                //take some action, but only if 3 == 4
                // then contine running AFTER the last else block
            }
            // else 
            else
            {
                //take some other action, but only if 3 != 3
            }


            // switch
            // switch (expression)
            switch (newint)
            { 
                case 1: // if (newint == 1)
                    Console.WriteLine("1");
                    break;
                case "2": // if (newint == "2")
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                default: //think else
                    Console.WriteLine("default");
                    break;
            }

            // loops

            // for loops, while loops

            // for (initialization; condition; increment)
            for (int i = 0; i < newint; i++)
            { 
                Console.WriteLine(i);
            }

            // while (condition) - a while loop continues until the condition is false

            while (newint < 10)
            {
                Console.WriteLine(newint);
                newint++;
            }

            // do while - will run at least once, even if the condition is false

            do
            {
                Console.WriteLine(newint);
                newint++;
            } while (false);


            // it's good form to build conditions into a single variable if they are overly complex.


            bool test = !(newint >= 5) || (newint <= 10);

            if (test)
            {

            }

           int addedValues =  AddValues(newint,2);

        }
        private int AddValues (int a, int b) // method signature
        {
            // variale scope = where is value/variable accesssible from?
            int answer = a + b;
            return answer;
        }


        // Object Oriented Programming/Principles
        // Encapsulation - richs bad gumball machine, or limit the access to outside parties (users, other systems, other classes) to
            // only the parts that they need to know about.



        // Abstraction - hiding the details of how something works. think "black box", or the bad coffee machine example rich came up with. 
            // feed it inputs, and know what kind of output to expect.


        // Inheritance - creating new classes from existing classes. Can be described as an "Is-A" relationship.
            // a child/sub/derived class "is a" parent/super/base class. a dog "is an" animal.
            // inherited classes will recieve all the members (fields and methods) of the parent class.

            //          animal                                  animal          tree
            //          /     \                                     \            /  
            //         dog     cat                                      lichen?
            //         |                                                TRUE Multiple inheritance is a NO NO!
            //         german shepard                                   but we can fake it with interfaces

        // Polymorphism - taking on many forms, through method overloading and overriding
            // overloading - same method name, but different parameters
                // example: AddValues(int a, int b)
                // example: AddValues(int a, int b, int c)
                // example: AddValues(double a, int b)
            // overriding - same method as the parent, but different functionality


    }
}
