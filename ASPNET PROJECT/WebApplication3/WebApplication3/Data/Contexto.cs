using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;
using WebApplication3.Models.Enums;
using WebApplication3.Models.ModelViews;

namespace WebApplication3.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            :base(options) 
        { }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }
        public DbSet<Seller> Sellers { get; set; }
    }
}
