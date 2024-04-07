using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using MIST353GroupProjectFranticFroggyFirms.Entities;
using MIST353GroupProjectFranticFroggyFirms.Entities;
using MIST353GroupProjectFranticFroggyFirms.Repositories;

namespace MIST353GroupProjectFranticFroggyFirms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : Controller
    {
        private readonly IHotelService hotelService;
        public HotelsController(IHotelService hotelService)
        {
            this.hotelService = hotelService;
        }
        [HttpGet("{hotelid}")]
        public async Task<List<Hotel>> ReturnHotelDetails(int hotelid)
        {
            var hotelDetails = await hotelService.ReturnHotelDetails(hotelid);
            if (hotelDetails == null)
            {
                //return NotFound();
            }
            return hotelDetails;
        }


    }
}