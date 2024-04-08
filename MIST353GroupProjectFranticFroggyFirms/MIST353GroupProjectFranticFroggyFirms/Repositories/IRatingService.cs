using MIST353GroupProjectFranticFroggyFirms.Entities;
using System.Threading.Tasks;


namespace MIST353GroupProjectFranticFroggyFirms.Repositories
{
    public class IRatingService
    {
        public Task<List<HotelRatings>> ReturnRatings(int hotelid);
    }
}