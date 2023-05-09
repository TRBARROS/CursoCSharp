using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            :base(options) 
        { }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
