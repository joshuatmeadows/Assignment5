using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MIST353GroupProjectFranticFroggyFirms.Data;
using MIST353GroupProjectFranticFroggyFirms.Entities;
using MIST353GroupProjectFranticFroggyFirms.Repositories;

//Created by Brooke M.
namespace MIST353GroupProjectFranticFroggyFirms.Repositories
{
    public class HotelRoomAvail : IHotelRoomAvail
    {
        private readonly DbContextClass _dbContextClass;
        public HotelRoomAvail(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<Hotel>> GetHotelRoomAvail(int hotelId)
        {
            var param = new SqlParameter("@hotelid", hotelId);
            var hotelRoomAvailByDate = await _dbContextClass.Hotel.FromSqlRaw("execute spRoomGetAvailyByDate @hotelid", param).ToListAsync();
            return hotelRoomAvailByDate;
        }

    }
}
