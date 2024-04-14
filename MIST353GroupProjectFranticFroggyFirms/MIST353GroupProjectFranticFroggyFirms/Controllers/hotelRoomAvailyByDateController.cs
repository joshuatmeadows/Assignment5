using Microsoft.AspNetCore.Mvc;
using MIST353GroupProjectFranticFroggyFirms.Entities;
using MIST353GroupProjectFranticFroggyFirms.Repositories;

namespace MIST353GroupProjectFranticFroggyFirms.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class hotelRoomAvailyByDateController : Controller
    {
        // You had the wrong name here
        private readonly IHotelRoomAvail hotelService;
        public hotelRoomAvailyByDateController(IHotelRoomAvail hotelService)
        {
            this.hotelService = hotelService;
        }
        [HttpGet("{gethotelRoomAvailyByDate}")]
        public async Task<List<Hotel>> HotelGetRoomAvailyByDate(int hotelid)
        {
            var hotelRoomAvailyByDate = await hotelService.GetHotelRoomAvail(hotelid);
            if (hotelRoomAvailyByDate == null)
            {
                //          return NotFound();
            }
            return hotelRoomAvailyByDate;

        }


    }
}