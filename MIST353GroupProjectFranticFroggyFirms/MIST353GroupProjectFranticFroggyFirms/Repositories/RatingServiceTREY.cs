using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MIST353GroupProjectFranticFroggyFirms.Data;
using MIST353GroupProjectFranticFroggyFirms.Entities;
using MIST353GroupProjectFranticFroggyFirms.Repositories;

namespace MIST353GroupProjectFranticFroggyFirms.Repositories
{
    public class RatingService : IRatingService
    {
        private readonly DbContextClass _dbContext;
        public RatingService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<HotelRatings>> ReturnRatings(int hotelid)
        {
            var param = new SqlParameter("HotelID", hotelid);
            var hotelRatings = await Task.Run(() => _dbContext.HotelRatings.FromSqlRaw("spReturnRatings @HotelID", param).ToListAsync());
            return hotelRatings;
        }
    }
}