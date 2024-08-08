import React, { createContext, useContext, useState, ReactNode  } from 'react';

//First, because we are using typescript we have to define the shape of our context.
//Context is just a fancy term for a state that can be accessed by a parent's child components.
interface UserContextType {
    user: string | null;
    login: (username: string) => void;
    logout: () => void;
}

//Next, I have to create a context with a default value. In our case, it will be null, at least for now.
const UserContext = createContext<UserContextType | null>(null);

//We have to create a context provider. We will render other components, that need access to this context, 
//inside of our context provider
function UserProvider({ children }: {children: ReactNode}) {

    //Inside of our provider, we will call useState. Our provider will give access to this state, 
    //as well as it's setter function to any child component rendered within it, that needs it. 
    const [user, setUser] = useState<string | null>(null);

    //Function to log a user in
    function login(username: string) {
        setUser(username);
    }

    //Function to log a user out
    function logout() {
        setUser(null);
    }

    return( //Our return looks a little different
        //We call the UserContext provider and we tell it what it will provide to any children rendered within it.
        //In our case, children are given access to user, login, and logout. 
        <UserContext.Provider value={{user, login, logout}}>
            {children}
        </UserContext.Provider>
    );
}

//Here we will choose to make a custom hook, to use our UserContext. 
function useUser() {
    const context = useContext(UserContext);

    if(!context) {
        throw new Error('useUser can only be used from inside of a UserProvider!');
    }

    return context;
}

//Exporting this so that we can use it throughout our app as needed. 
export {UserProvider, useUser};
