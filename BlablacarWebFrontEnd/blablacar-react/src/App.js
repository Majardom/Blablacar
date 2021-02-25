import './App.scss';
import NavigationBar from './Components/Navigation/NavigationBar/NavigationBar'
import { Route, Link } from 'react-router-dom';
import HomePage from './Components/Pages/HomePage/HomePage';
import TripsPage from './Components/Pages/TripsPage/TripsPage';
import  DialogProvider from './Components/Dialogs/DialogProvider';

function App() {
  return (
    <DialogProvider>
      <div className="App">
        <NavigationBar></NavigationBar>
        <Route exact path="/" component={HomePage} />
        <Route exact path="/trips" component={TripsPage} />
      </div>
    </DialogProvider>
  );
}

export default App;
