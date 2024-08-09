import Counter from "./components/Counter/Counter";
import UserStatus from "./components/UserStatus/UserStatus";
import DataFetcher from "./components/DataFetcher/DataFetcher";
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
        {/*Displaying my DataFetcher and it's child PostList that is rendered inside of it */}
        <DataFetcher />
      </div>
  
   
  )
}

export default App
