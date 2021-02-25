export default class TripsService
{
    static trips = [{
        id: 0,
        customer: {id: 0,  gender: "Female", name: "Some Customer", phoneNumber: "380934234234"},
        departureTime: new Date().toString(),
        driver: {id: 0,  gender: "Female", name: "Some Driver", phoneNumber: "380934234234"},
        from: "Kyiv",
        to: "Lviv",
        price: 300
     },
     {
        id: 0,
        customer: {id: 0,  gender: "Female", name: "Some Customer", phoneNumber: "380934234234"},
        departureTime: new Date().toString(),
        driver: {id: 0,  gender: "Female", name: "Some Driver", phoneNumber: "380934234234"},
        from: "Kyiv",
        to: "Lviv",
        price: 300
     }];

     getAllTrips() {
         return TripsService.trips;
     }

     addTrip(trip) {
        TripsService.trips.push(trip);
     }

}