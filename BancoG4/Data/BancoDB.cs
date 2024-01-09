using Microsoft.EntityFrameworkCore;
using Model;

namespace Data
{
    public class BancoDB : DbContext
    {
        public BancoDB(DbContextOptions<BancoDB> options): base(options)
        {
        
        }
        public DbSet<Cliente> Clientes => Set<Cliente>();
    }
}
