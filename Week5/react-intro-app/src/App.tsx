import Counter from "./components/Counter/Counter";
import UserStatus from "./components/UserStatus/UserStatus";
import { UserProvider } from "./UserContext";

function App() {

  return (

    
      <div>
        {/*Displaying my UserStatus component.*/}
        <UserProvider>
          <UserStatus />
        </UserProvider>
        {/*Displaying my *custom* Counter component! Notice that unlike the HTML div element tag, I use a 
        capital letter to start off my react component name!*/}
        <Counter />
      </div>
  
   
  )
}

export default App
