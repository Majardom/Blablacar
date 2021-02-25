
import TripsService from '../../../Services/TripsService';
import TripTile from './TripTile';
import './TripsPage.scss';

const TripsPage = () => {
    const tripsService = new TripsService();

    return (
        <div className="tiles">
           {tripsService.getAllTrips().map(trip => (
               <TripTile trip={trip}/>
           ))}
        </div>
    );
};

export default TripsPage;