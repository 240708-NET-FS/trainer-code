//I have to import the useState (or whatever hooks Im using) from 'react'
import React, { useState } from 'react'


function Counter() {

    //Here, Im going to leverage the useState hook to manage the state of my Counter component.
    //Im going to store a number that persists between component re-renders to display to the user,
    //and I will increment or decrement that number based on the user clicking on HTML buttons in the returned
    //html that is rendered.
    const [count, setCount] = useState<number>(0);

    //This is a function to increment the count in our state
    function increment() {
        setCount(count + 1);
    }

    //This is a function to decrement the count in our state
    function decrement() {
        setCount(count - 1);
    }

  return (
    <div>
        <h4>Counter Component</h4>
        {/*Displaying my current count, notice how I can use the curly braces to 
        easily refer to a TS variable name*/}
        <p>Current Count: {count}</p>
        <button onClick={increment}>Increment</button>
        <button onClick={decrement}>Decrement</button>
    </div>
  )
}

export default Counter;