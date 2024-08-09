import React, { useReducer }from 'react'


//First, we have to define the shape of our state
interface FormState {
    name: string;
    email: string;
}

//Second, we define the possible actions (events that trigger state update) for our component
//In this case, we can set the name, set the email, or just reset the form and our state
type ActionType = 
      {type: 'setName'; payload: string}
    | {type: 'setEmail'; payload: string}
    | {type: 'reset'};

//This is going to be my reducer function to handle the different possible state changes
function formReducer(state: FormState, action: ActionType): FormState {
    switch (action.type) {
        case 'setName':
            return{ ...state, name: action.payload};
        case 'setEmail':
            return{ ...state, email: action.payload};
        case 'reset':
            return {name: '', email: ''};
        default:
            throw new Error("Unkown action type?");
    }//end switch
}//end formReducer


function FormWithReducer() {

    //Leveraging useReducer to manage the state of our component
    const [state, dispatch] = useReducer(formReducer, {name: '', email: ''});

    //Event handling functions that call/dispatch our actions based on user input to our HTML form below
    function handleNameChange(event: React.ChangeEvent<HTMLInputElement>) {
        dispatch({type: 'setName', payload: event?.target.value});
    }

    function handleEmailChange(event: React.ChangeEvent<HTMLInputElement>) {
        dispatch({type: 'setEmail', payload: event?.target.value})
    }

    function handleReset() {
        dispatch({type: 'reset'});
    }

  return (
    <div>
        <h3>User Info Form</h3>
        {/*Updating the name based on user input*/}
        <div>
            <label>Name:</label>
            <input type="text" value={state.name} onChange={handleNameChange}/>
        </div>
        
        {/*Updating the email baesd on user input*/}
        <div>
            <label>Email:</label>
            <input type="text" value={state.email} onChange={handleEmailChange}/>
        </div>

        {/*Displaying the current state */}
        <div>
            <p>Current Name in state: {state.name} </p>
            <p>Current Email in state: {state.email} </p>
        </div>

        <button onClick={handleReset}>Reset form!</button>
        
    </div>
  )
}

export default FormWithReducer