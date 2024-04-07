using System.Threading.Tasks;
using MIST353GroupProjectFranticFroggyFirms.Entities;

namespace MIST353GroupProjectFranticFroggyFirms.Repositories
{
    public interface IEllaAPI
    {
        public Task<List<Hotel>> spHotelSearchByRadius(decimal latitude, decimal longitude);
        public Task<List<RoomAvail>> spRoomGetAvailabilityByDateRange(DateTime StartDate, DateTime EndDate);
    }

}