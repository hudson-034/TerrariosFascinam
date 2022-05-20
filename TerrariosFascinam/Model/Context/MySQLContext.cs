using Microsoft.EntityFrameworkCore;

namespace TerrariosFascinam.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {

        }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {

        }
        public DbSet<Client> Clients { get; set; }
    }
}
