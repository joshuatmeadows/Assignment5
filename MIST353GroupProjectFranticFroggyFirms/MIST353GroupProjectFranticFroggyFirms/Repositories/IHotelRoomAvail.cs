using MIST353GroupProjectFranticFroggyFirms.Entities;
using System.Threading.Tasks;

//Created by Brooke M.
namespace MIST353GroupProjectFranticFroggyFirms.Repositories
{
    public interface IHotelRoomAvail
    {
        Task<List<Hotel>> GetHotelRoomAvail(int hotelId);
    }
}