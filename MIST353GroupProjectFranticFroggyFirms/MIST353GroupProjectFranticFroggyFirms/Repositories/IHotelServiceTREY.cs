using MIST353GroupProjectFranticFroggyFirms.Entities;
using System.Threading.Tasks;


namespace MIST353GroupProjectFranticFroggyFirms.Repositories
{
    public interface IHotelService
    {
        public Task<List<Hotel>> ReturnHotelDetails(int hotelid);
    }
}