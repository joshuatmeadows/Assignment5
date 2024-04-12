using System.Threading.Tasks;
using MIST353GroupProjectFranticFroggyFirms.Entities;

namespace MIST353GroupProjectFranticFroggyFirms.Repositories
{
    public interface IEllaAPI
    {
        public Task<List<Hotel>> spHotelSearchByRadius(decimal latitude, decimal longitude)
        {
            throw new NotImplementedException();
        }
        public Task<List<Entities.RoomAvail>> spRoomGetAvailabilityByDateRange(DateTime StartDate, DateTime EndDate)
        {
            throw new NotImplementedException();
        }
    }

}