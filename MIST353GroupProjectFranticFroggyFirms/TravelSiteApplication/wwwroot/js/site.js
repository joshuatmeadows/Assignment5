// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//To get Room Availibilty by date range
async function displayRoomAvailResults(StartDate, EndDate) {
    const response = await fetch('https://localhost:7282/api/Ella/RoomGetAvailabilityByDateRange/StartDate=${StartDate}&EndDate=${EndDate}');
    const data = await response.json();
    var innerHtml =""; 
    for (let i = 0; i < length(data); i++) {
        innerHtml += `<div style="card"><a herf="https://localhost:7141/HotelInfo?HotelID={data[i].HotelID}" >${data[i].RoomID}</a></div>`
    }
    document.getElementById('results').innerHTML = innerHtml;
}

    
// to get hotel detail
async function displayHotelDetails(hotelid) {
    const response = await fetch(`https://localhost:7095/api/Hotels/${HotelID}`);
    // need correct API
    const data = await response.json();
    document.getElementById('Name').innerHTML = data[0].Name;
    document.getElementById('Name').style.visibility = "visible";
    document.getElementById('hotelAddress').innerHTML = data[0].address;
    document.getElementById('hotelAddress').style.visibility = "visible";
    document.getElementById('hotelContact').innerHTML = data[0].Phone + ", " + data[0].Email;
    document.getElementById('hotelContact').style.visibility = "visible";


// get location by lat and long
async function displayHotelSearchByRadius(latitude, longitude) {
    const response = await fetch(`https://localhost:7282/api/Ella/HotelSearchByRadius/longitude=${longitude}&latitude=${latitude}`);
    const data = await response.json();
    var innerHtml = "";
    for (let i = 0; i < data.length; i++) {
        innerHtml += `<div style="card"><a href="https://localhost:7146/hotel?hotelid=${data[i].HotelID}">${data[i].name}</a></div>`
    }
    document.getElementById("hotelResults").innerHTML = innerHtml;
    document.getElementById('hotelResults').style.visibility = "visible";
}

}

//search button on searchpage goes to hotelinfo
document.getElementById('searchbyCoordinates').addEventListener('submit', function (event) {
    event.preventDefault();

    var latitude = parseFloat(document.getElementById('LatInp').value);
    var longitude = parseFloat(document.getElementById('LongInp').value);

    if (!isNaN(latitude) && !isNaN(longitude)) {
        window.location.href = `https://localhost:7146/hotelInfo?latitude=${latitude}&longitude=${longitude}`;
    } else {
        alert("Please enter valid latitude and longitude values");
    }
});