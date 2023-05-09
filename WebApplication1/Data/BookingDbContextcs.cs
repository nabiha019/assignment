using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;

namespace WebApplication1.Data
{
    public class BookingDbContextcs : DbContext
    {
        
        public BookingDbContextcs(DbContextOptions<BookingDbContextcs> options) : base(options)
        {

        }
        public DbSet<InfoData> User_Details { get; set; }
    }
}

