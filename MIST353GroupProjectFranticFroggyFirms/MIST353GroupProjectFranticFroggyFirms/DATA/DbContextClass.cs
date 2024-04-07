using MIST353GroupProjectFranticFroggyFirms.Entities;
using Microsoft.EntityFrameworkCore;
namespace MIST353GroupProjectFranticFroggyFirms.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        { }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<HotelRatings> HotelRatings { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<ReservationLines> ReservationLines { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomAvail> RoomAvail { get; set; }

    }
}