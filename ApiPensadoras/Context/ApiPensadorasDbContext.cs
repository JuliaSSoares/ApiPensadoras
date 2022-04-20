using ApiPensadoras.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiPensadoras.Context
{
    public class ApiPensadorasDbContext : DbContext
    {
        public ApiPensadorasDbContext(DbContextOptions<ApiPensadorasDbContext> options ) : base( options )
        {}
        //mapeia a entidade Pensadora para a tabela Pensadoras
        public DbSet<Pensadora>? Pensadoras { get; set; }

        //mapeia a entidade Frase para a tabela Frases
        public DbSet<Frase>? Frases  { get; set; }    
    }
}
