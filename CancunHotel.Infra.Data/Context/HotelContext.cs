using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CancunHotel.Infra.Data.Context
{
    public class HotelContext : DbContext

    {
        readonly IConfiguration _configuration;

        public HotelContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("AppDb");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
