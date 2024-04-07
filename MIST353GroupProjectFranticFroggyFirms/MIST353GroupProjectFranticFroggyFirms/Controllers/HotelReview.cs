using Microsoft.AspNetCore.Mvc;
using MIST353GroupProjectFranticFroggyFirms.Entities;
using MIST353GroupProjectFranticFroggyFirms.Repositories;

namespace MIST353GroupProjectFranticFroggyFirms.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class HotelReviewController : ControllerBase
    {
        private readonly IHotelService _hotelService;
        public HotelReviewController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }
        [HttpGet("{hotelid}")]
        public async Task<ActionResult<List<HotelReview>>> GetHotelReview(int hotelid)
        {
            var HotelReview = await _HotelService.GetHotelReview(hotelid);
            return HotelReview;
        }

    }

}