# JavaScript (!== Java)

### tldr;
- scripting language
- dynamically typed
- language of choice for web browsers
- standalone JS runtime: Node.js

### Trivias
- Created by Brendan Eich in approximately a week (he's still around! Creator of Brave browser)
- Javascript was named javascript because the creator wanted to piggyback off of Java's popularity at the time
- JS standard is called ECMAScript
- interpreted or Just-In-Time compiled

### Data Types
- while js is weak, dynamically typed language, it does not mean it has no data types!
- String, Undefined, Null (!= undefined), Boolean, Object, Numbers... and more.
- SUNBONS -> String, Undefined, Null, Boolean, Object, Number, Symbol

#### Type Coersion
- Be careful with JS's type coersion!
- JS will "help" you by automatically converting a certain data type to another. (without telling you)
- You can do `1 + "1"`, but should you really?

##### == vs ===
tldr; Always opt for === and !== 

### Truthy and Falsey values
Truthy values are : true, 1, "any non empty string", any object
Falsey values are: false, 0, "", null, undefined

### Variables and Scopes
- declare variables using keywords `let` and `const`
- `let` if you want to change what's assigned later
- `const` if you want to prevent it from changing later
  - `const` is more commonly used than you think in js
- 3 scopes:
  - Global
  - Functional
  - Block

### Functions
- In JS, functions are first-class members of the language: that is, it doesn't need to be contained within other types unlike C#.

### DOM (Document Object Model)
#### What is it?
- a tree representing the document structure
- an interface to interact with said structure.
#### Why do we care?
Javascript interacts with html page via DOM

### Events
#### What is it?
Anything happening in the web page. Mostly user interactions, but also some browser events as well.

#### Why do we care?
This is how javascript is primarily used in the web page.

#### Terms of interest
- Event Handler/Listener: a function that has been assigned to respond to a certain event
- Bubbling: event travels up through the dom from the target element
- Capturing: once the event reaches the top, it traverses back down to the target element
- e.stopPropagation() will stop this bubble/capture process

### Async Javascript
Important because fe is nothing w/o data and we get that data via http call, asynchronously.

#### Fetch API
- native js way to send http calls
- uses promise: a way to represent async calls

#### Promise
- Like Task of C#
- .then() is where you pass in the callback function
- .catch() is where you handle when something doesn't go right

#### Async/await
- Syntactic sugar over promise
- works the same way C# async/await works
- allows you to flatten out your nested promises.

### JSON
- "JavaScript Object Notation"
- js object !== JSON
- a language agnostic way to describe data
- Peculiarities:
  - Keys Must be "string"
  - No trailing comma

### The infamous `this` keyword
- The issue with `this` in js is that it changes meaning based on context.
- [Official MDN doc](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/this)
- there are a lot of different context/nuances one could delve themselves into, but here are two pertinent ones to know
  - Inside classes/constructors, `this` works the same way as C#. As in, `this` in constructors and instance fields/methods refers to the object, for static fields/methods it's the class itself
  - For event listeners (functions bound to certain events), `this` is the event
- You can change the `this` context by using `.call()`, `.apply()` or `.bind()` method
- tldr; stick to conventions and best practices, there's a reason they're there