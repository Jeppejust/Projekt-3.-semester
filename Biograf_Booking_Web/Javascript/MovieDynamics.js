/*
    Created: December 6, 2019
    Author: 
    Purpose: 
*/

// When seat is clicked - get values and update reserved seats string accordingly
function seatchange(clickedSeatNo) {
    var seatNoStr = "" + clickedSeatNo;
    var currentSeat = document.getElementById(seatNoStr);
    var foundReservationValue = currentSeat.value;
    if (foundReservationValue === '0') {
        SetReservedSeats(clickedSeatNo, true);
        currentSeat.value = 1;
    } else {
        SetReservedSeats(clickedSeatNo, false);
        currentSeat.value = 0;
    }
}

// Update reserved seats string
// Todo: remove alerts
function SetReservedSeats(seatNo, doAdd) {
    var actualReservedSeats = document.getElementById("reservedSeats");
    var seatsStr = actualReservedSeats.value;
    var newSeatsStr = '';
    if (doAdd) {
        newSeatsStr = seatsStr.concat(":" + seatNo);
    } else {
        newSeatsStr = seatsStr.replace(":" + seatNo, '');
    }
    actualReservedSeats.value = newSeatsStr;
}

// Just for test
function getReservedSeatsValue() {
    var actualReservedSeats = document.getElementById("reservedSeats");
    var seatsStr = actualReservedSeats.value;
    return seatsStr;
}
// Just for alerts
function VerifyReservation(Verified) {

    if (Verified) {
        alert("Din reservation er gået igennem");
    } else {
        alert("Noget gik galt, prøv igen");
    }
}