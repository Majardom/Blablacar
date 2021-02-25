import './App.scss';
import NavigationBar from './Components/Navigation/NavigationBar/NavigationBar'
import {Route, Link} from 'react-router-dom';
import HomePage from './Components/Pages/HomePage/HomePage';
import TripsPage from './Components/Pages/TripsPage/TripsPage';
import CreateTripPage from './Components/Pages/CreateTripPage/CreateTripPage';

function App() {
  return (
    <div className="App">
       <NavigationBar></NavigationBar>
       <Route exact path="/" component={HomePage}/>
       <Route exact path="/trips" component={TripsPage}/>
       <Route exact path="/createTrip" component={CreateTripPage}/>
    </div>
  );
}

export default App;
