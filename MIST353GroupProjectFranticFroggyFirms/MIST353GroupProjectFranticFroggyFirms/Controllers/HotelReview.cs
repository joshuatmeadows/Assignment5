using Microsoft.AspNetCore.Mvc;
using MIST353GroupProjectFranticFroggyFirms.Entities;
using MIST353GroupProjectFranticFroggyFirms.Repositories;

namespace MIST353GroupProjectFranticFroggyFirms.Controllers

{
    [Route("api[controller]")]
    [ApiController]
    public class HotelReviewController : ControllerBase
    {
        private readonly IHotelReview _hotelService;
        public HotelReviewController(IHotelReview hotelService)
        {
            _hotelService = hotelService;
        }
        [HttpGet("{hotelid}")]
        // Output should be entitiy not controller
        public async Task<ActionResult<List<HotelReview>>> GetHotelReview(int hotelid)
        {
            var HotelReview = await _hotelService.GetHotelReview(hotelid);
            return HotelReview;
        }

    }

}
