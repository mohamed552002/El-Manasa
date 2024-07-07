import { createBrowserRouter, RouterProvider } from "react-router-dom"
import Layout from "./components/Layout/Layout"
import Login from "./components/Login/Login"
import Register from './components/Register/Register';
import NotFound from "./components/NotFound/NotFound";
import Home from "./components/Home/Home";

const router=createBrowserRouter([
  {path:"",element:<Layout/>,children:[
    {index:true,element:<Home/>},
    {path:'login',element:<Login/>},
    {path:'register',element:<Register/>},
    {path:'*',element:<NotFound/>}
  ]}x

])
function App() {
  return <>
  <RouterProvider router={router}>

  </RouterProvider>

  </>
  
  
}

export default App
