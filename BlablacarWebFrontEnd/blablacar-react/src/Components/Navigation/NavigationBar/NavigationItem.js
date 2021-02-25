import { Link } from 'react-router-dom';
import './NavigationItem.scss';


const NavigationItem = ({ menuItem }) => {

    if (menuItem.routeLink) {
        return (
            <Link key={menuItem.routeLink} className="item-host" to={menuItem.routeLink}>
                <div className="caption">
                    {menuItem.caption}
                </div>
            </Link>
        );
    } else {
        return (
            <div key={menuItem.routeLink} className="item-host">
                <div className="caption">
                    {menuItem.caption}
                </div>
            </div>
        );
    }
};

export default NavigationItem;