using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using   MIST353GroupProjectFranticFroggyFirms.Entities;
using MIST353GroupProjectFranticFroggyFirms.Repositories;

namespace TravelCreation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class hotelRoomAvailyByDateController : Controller
   {
       private readonly IHotelService hotelService;
        public hotelRoomAvailyByDateController(IHotelService hotelService)
        {
            this.hotelService = hotelService;
       }
       [HttpGet("{gethotelRoomAvailyByDate}")]
        public async Task<List<Hotel>> gethotelRoomAvailyByDate(int hotelid)
        {
            var hotelRoomAvailyByDate = await hotelService.hotelRoomAvailyByDate(hotelid);
           if (hotelRoomAvailyByDate == null)
            {
           //   return NotFound();
            }
           return hotelRoomAvailyByDate;

        }


    }
}