
import React from 'react';
import Button from '@material-ui/core/Button';
import TextField from '@material-ui/core/TextField';
import Dialog from '@material-ui/core/Dialog';
import DialogActions from '@material-ui/core/DialogActions';
import DialogContent from '@material-ui/core/DialogContent';
import DialogContentText from '@material-ui/core/DialogContentText';
import DialogTitle from '@material-ui/core/DialogTitle';
import TripsService from '../../../Services/TripsService';
import { useDialog } from "../../Dialogs/DialogProvider";
const { useState } = React;

const CreateTripPage = () => {
    const service = new TripsService();
    const [openDialog, closeDialog] = useDialog();

    const [trip, setState] = useState({
        from: '',
        to: ''
    });
    

    const handleClose = () => {
        closeDialog();
    };

    const createTrip = () => {
        
        service.addTrip( {
            id: 0,
            customer: {id: 0,  gender: "Female", name: "Some Customer", phoneNumber: "380934234234"},
            departureTime: new Date().toString(),
            driver: {id: 0,  gender: "Female", name: "Some Driver", phoneNumber: "380934234234"},
            from: trip.from,
            to: trip.to,
            price: 300
         })

        closeDialog();
    }

    const valueChange = (e) => {
        const value = e.target.value;
        setState({
            ...trip,
            [e.target.name]: value
        });
    }

    return (
        <div className="content">
            <DialogContent className="content">
                <div className="route">
                    <TextField autoFocus
                        margin="dense"
                        name="from"
                        label="From"
                        fullWidth
                        value={trip.from}
                        onChange={valueChange}
                    />

                    <TextField autoFocus
                        margin="dense"
                        name="to"
                        label="To"
                        fullWidth
                        value={trip.to}
                        onChange={valueChange}
                    />
                </div>

            </DialogContent>
            <DialogActions>
                <Button onClick={handleClose} color="primary">
                    Cancel
                </Button>
                <Button onClick={createTrip} color="primary">
                    Create
                </Button>
            </DialogActions>
        </div>
    );
};

export default CreateTripPage;