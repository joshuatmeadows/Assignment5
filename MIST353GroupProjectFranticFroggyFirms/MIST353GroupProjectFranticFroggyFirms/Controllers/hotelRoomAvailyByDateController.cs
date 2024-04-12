using Microsoft.AspNetCore.Mvc;
using MIST353GroupProjectFranticFroggyFirms.Entities;
using MIST353GroupProjectFranticFroggyFirms.Repositories;

namespace MIST353GroupProjectFranticFroggyFirms.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class hotelRoomAvailyByDateController : Controller
    {
        private readonly IRoomAvail hotelService;
        public hotelRoomAvailyByDateController(IRoomAvail hotelService)
        {
            this.hotelService = hotelService;
        }
        [HttpGet("{gethotelRoomAvailyByDate}")]
        public async Task<List<Hotel>> HotelGetRoomAvailyByDate(int hotelid)
        {
            var hotelRoomAvailyByDate = await hotelService.RoomGetAvailyByDate(hotelid);
            if (hotelRoomAvailyByDate == null)
            {
                //          return NotFound();
            }
            return hotelRoomAvailyByDate;

        }


    }
}