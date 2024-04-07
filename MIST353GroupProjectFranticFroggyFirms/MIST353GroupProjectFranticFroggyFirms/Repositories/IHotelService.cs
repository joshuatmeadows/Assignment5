using MIST353GroupProjectFranticFroggyFirms.Entities;


namespace TravelCreation.Repositories
{
    public interface IHotelService
    {
        public Task<List<Hotel>> RoomGetAvailyByDate(int hotelid);
    }
}