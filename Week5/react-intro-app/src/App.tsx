import Counter from "./components/Counter/Counter";
import UserStatus from "./components/UserStatus/UserStatus";
import DataFetcher from "./components/DataFetcher/DataFetcher";
import FormWithReducer from "./components/FormWithReducer/FormWithReducer";
import { UserProvider } from "./UserContext";
import { BrowserRouter, Route, Routes, Link } from "react-router-dom";

function App() {

  return (

    <BrowserRouter>
      <div>

          {/*Using a simple nav menu to better illustrate BrowserRouter functionality */}
          <nav>
            <ul>
              <li>
                  <Link to='/'>Home</Link>
              </li>
              <li>
                  <Link to='/counter'>Counter</Link>
              </li>
              <li>
                  <Link to='/data-fetcher'>Forum Posts</Link>  
              </li>
              <li>
                  <Link to='/form'>Form with Reducer</Link>
              </li>
            </ul>
          </nav>

          {/*Defining Routes for my components, as well as a default/root route */}
      
            <Routes>
              <Route path="/" 
              element={<UserProvider>
                          <UserStatus/>
                      </UserProvider>}/>
              
              
              <Route path="/counter" element={<Counter/>}/>
              <Route path="/data-fetcher" element={<DataFetcher/>}/>
              <Route path="/form" element={<FormWithReducer/>}/>
            </Routes>
      </div>






    </BrowserRouter>
   
  )
}

export default App
