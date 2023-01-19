using System.Data.Entity;
using TSEAlert.Models;

namespace TSEAlert.DAL
{
    public class DbContextFactory : DbContext
    {
        public DbContextFactory() : base("name=DBConnectionString")
        {
        }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Alert> Alerts { get; set; }
        public DbSet<AlertMessage> AlertMessages { get; set; }
    }
}
