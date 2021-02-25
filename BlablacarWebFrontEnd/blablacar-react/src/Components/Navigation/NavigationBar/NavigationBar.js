import './NavigationBar.scss';
import NavigationItem from './NavigationItem';

const NavigationBar = () => {
    const menuItems = [];
    menuItems.push({ key: 0, caption: "Home", iconName: "home.svg", routeLink: "/" });
    menuItems.push({ key: 1, caption: "Create New Trip", iconName: "plus.svg", onClick: "createTrip"});
    menuItems.push({ key: 2, caption: "Available Trips", iconName: "car_svg", routeLink: "/trips" });
    menuItems.push({ key: 3, caption: "Booked Trips", iconName: "booked.svg", routeLink: "/" });
    menuItems.push({ key: 4, caption: "Log Out", iconName: "logout.svg", customClasses: ["logout"], routeLink: "/" });

    return(
        <div className="nav-inner-container">
            {menuItems.map(menuItem => (
                <NavigationItem key={menuItem.key}  menuItem={menuItem}></NavigationItem>
            ))}
        </div>
    );
};

export default NavigationBar;