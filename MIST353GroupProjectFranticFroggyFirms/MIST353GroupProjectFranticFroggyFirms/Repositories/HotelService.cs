using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MIST353GroupProjectFranticFroggyFirms.Data;
using MIST353GroupProjectFranticFroggyFirms.Entities;
using MIST353GroupProjectFranticFroggyFirms.Repositories;

namespace MIST353GroupProjectFranticFroggyFirms.Repositories
{
    public class HotelService : IHotelService
    {
        private readonly DbContextClass _dbContextClass;
        public HotelService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<Hotel>> RoomGetAvailyByDate(int hotelid)
        {
            var param = new SqlParameter("@hotelid", hotelid);
            var hotelRoomAvailyByDate = await Task.Run(() => _dbContextClass.Hotel.FromSqlRaw("execute spRoomGetAvailyByDate @hotelid", param).ToListAsync());
            return hotelRoomAvailyByDate;
        }


    }
}