import { Link } from 'react-router-dom';
import './NavigationItem.scss';
import CreateTripPage from '../../Pages/CreateTripPage/CreateTripPage';
import React from "react";
import { useDialog } from "../../Dialogs/DialogProvider";

const NavigationItem = ({ menuItem }) => {
    const [openDialog, closeDialog] = useDialog();

    const handleClick = () => {
        if(menuItem.onClick == "createTrip")
        {
            openDialog({
                children: (
                  <CreateTripPage/>
                )
            })
        }
    }

    if (menuItem.routeLink) {
        return (
            <Link className="item-host" to={menuItem.routeLink}>
                <div className="caption">
                    {menuItem.caption}
                </div>
            </Link>
        );
    } else {
        return (
            <div className="item-host" onClick={handleClick}>
                <div className="caption">
                    {menuItem.caption}
                </div>
            </div>
        );
    }
};

export default NavigationItem;