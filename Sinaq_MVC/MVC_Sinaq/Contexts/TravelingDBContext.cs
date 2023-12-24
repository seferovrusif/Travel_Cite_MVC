using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_Sinaq.Models;

namespace MVC_Sinaq.Contexts
{
    public class TravelingDBContext:IdentityDbContext    
    {
        public TravelingDBContext(DbContextOptions option):base(option) { }
        public DbSet<Destination> Destinations { get; set; }
    }
}
