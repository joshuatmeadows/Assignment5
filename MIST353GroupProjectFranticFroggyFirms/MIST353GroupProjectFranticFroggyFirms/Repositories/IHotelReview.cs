using MIST353GroupProjectFranticFroggyFirms.Entities;
using System.Threading.Tasks;
//Created by Brooke M.
namespace MIST353GroupProjectFranticFroggyFirms.Repositories
{
    public interface IHotelReview
    {
        public Task<List<HotelReview>> GetHotelReview(int hotelid);
    }
}