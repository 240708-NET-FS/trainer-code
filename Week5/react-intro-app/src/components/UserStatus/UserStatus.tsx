import React, {useState} from 'react'

import { useUser } from '../../UserContext'


function UserStatus() {
    //Accessing the context, via our useUser hook function that we created in UserContext.tsx 
    const { user, login, logout } = useUser();

    //Storing the user inputted username (from our text input element below) in this component's state.
    //Components can leverage both an individual state AND a context. Store information wherever it makes the most
    //sense. Not everything needs to (or should be) stored in a context. 
    const [username, setUsername] = useState<string>('');

  return (
    <div>
        {/*We will show different page content based on whether or not a user is logged in*/}
        {user ? (
            <div>
                <p>Welcome, {user}!</p>
                {/*If the user is currently logged in, we will display a logout button for them*/}
                <button onClick={logout}>Logout</button>
            </div>
        ) : (
            <div>
                <input 
                    type="text" 
                    placeholder="Enter Username"
                    value={username}
                    onChange={(e) => setUsername(e.target.value)}
                />
                {/*Login button that calls login function from UserContext*/}
                <button onClick={() => login(username)}>Login</button>
            </div>
        )}
    </div>
  )
}

export default UserStatus;