
import React from 'react';
import Button from '@material-ui/core/Button';
import TextField from '@material-ui/core/TextField';
import Dialog from '@material-ui/core/Dialog';
import DialogActions from '@material-ui/core/DialogActions';
import DialogContent from '@material-ui/core/DialogContent';
import DialogContentText from '@material-ui/core/DialogContentText';
import DialogTitle from '@material-ui/core/DialogTitle';
import TripsService from '../../../Services/TripsService';

export default class CreateTripDialogOpener {

}

const CreateTripPage = () => {
    const [open, setOpen] = React.useState(true);
    const service = new TripsService();

    const handleClose = () => {
       
        service.addTrip({
            id: 0,
            customer: {id: 0,  gender: "Female", name: "Some Customer", phoneNumber: "380934234234"},
            departureTime: new Date().toString(),
            driver: {id: 0,  gender: "Female", name: "Some Driver", phoneNumber: "380934234234"},
            from: "Kyiv",
            to: "Lviv",
            price: 300
         });

        setOpen(false);
      };

    return (
        <Dialog open={open} onClose={handleClose} aria-labelledby="form-dialog-title">
            <DialogTitle id="form-dialog-title">Create New Trip</DialogTitle>
            <DialogContent>
                <DialogContentText>
                    To subscribe to this website, please enter your email address here. We will send updates
                    occasionally.
                </DialogContentText>
                <TextField
                    autoFocus
                    margin="dense"
                    id="name"
                    label="Email Address"
                    type="email"
                    fullWidth
                />
            </DialogContent>
            <DialogActions>
                <Button onClick={handleClose} color="primary">
                    Cancel
                </Button>
                <Button onClick={handleClose} color="primary">
                    Subscribe
                </Button>
            </DialogActions>
        </Dialog>
    );
};

export default CreateTripPage;