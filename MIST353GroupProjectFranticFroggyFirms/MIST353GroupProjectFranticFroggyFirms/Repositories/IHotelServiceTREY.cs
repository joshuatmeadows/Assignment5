using MIST353GroupProjectFranticFroggyFirms.Entities;
using System.Threading.Tasks;


namespace MIST353GroupProjectFranticFroggyFirms.Repositories
{
    public interface IHotelService
    {
        Task<Microsoft.AspNetCore.Mvc.ActionResult<List<HotelReview>>> GetHotelReview(int hotelid);
        public Task<List<Hotel>> ReturnHotelDetails(int hotelid);
    }
}