using ApiPensadoras.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiPensadoras.Context
{
    public class ApiPensadorasDbContext : DbContext
    {
        public ApiPensadorasDbContext(DbContextOptions<ApiPensadorasDbContext> options ) : base( options )
        {}

        public DbSet<Pensadora>? Pensadoras { get; set; }
        public DbSet<Frase>? Frases  { get; set; }    
    }
}
