using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MIST353GroupProjectFranticFroggyFirms.Data;
using MIST353GroupProjectFranticFroggyFirms.Entities;
using MIST353GroupProjectFranticFroggyFirms.Repositories;
//Created by Brooke M.

namespace MIST353GroupProjectFranticFroggyFirms.Repositories
{

    public class HotelReviewService : IHotelReview
    {
        private readonly DbContextClass _dbContextClass;
        public HotelReviewService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<HotelReview>> GetHotelReview(int hotelid)
        {
            var param = new SqlParameter("@hotelid", hotelid);
            var myHotelReview = await Task.Run(() => _dbContextClass.HotelReview.FromSqlRaw("execute spHotelReview @hotelid", param).ToListAsync());
            return myHotelReview;
        }


    }
}