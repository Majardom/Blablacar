import './TripTile.scss';

const TripTile = ({trip}) => {
    return (
        <div className="tile">
            <header class="title row">From: {trip.from } To: { trip.to}</header>
            <section>
                <div class="driver row">Driver: {trip.driver.name }</div>
                <div class="depature-date row">Depature: { trip.departureTime }</div>
            </section>
            <footer>
                <div class="order row">
                    <div class="price">Price: {trip.price }</div>
                    <div class="order-btn" >Order</div>
                </div>
            </footer>
        </div>
    );
};

export default TripTile;