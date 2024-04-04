using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace MIST353GroupProjectFranticFroggyFirms.DATA
{

    
        public class DbContextClass : DbContext
        {
            public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
            { }
           // public DbSet<Hotel> Hotel { get; set; }
        }
    
}
