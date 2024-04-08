// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//To get Room Availibilty by date range
async function displayRoomAvailResults(StartDate, EndDate) {
    const response = await fetch('https://localhost:7282/api/Ella/RoomGetAvailabilityByDateRange/StartDate=${StartDate}&EndDate=${EndDate}');
    const data = await response.json();
    const innerHtml =""; 
    for (let i = 0; i < length(data); i++) {
        innerHtml += `<div style="card"><a herf="https://localhost:7141/HotelInfo?HotelID={data[i].HotelID}" >${data[i].RoomID}</a></div>`
    }
    document.getElementById('results').innerHTML = innerHtml;
}

// to get hotel detail
