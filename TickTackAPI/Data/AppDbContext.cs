using Microsoft.EntityFrameworkCore;
using TickTackAPI.models;

namespace TickTackAPI.Data
{
    public class AppDbContext:DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { }


        public DbSet<TimerItem> timers{  get; set; }
    }
}
