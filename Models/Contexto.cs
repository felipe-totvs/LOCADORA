using Microsoft.EntityFrameworkCore;

namespace LOCADORA.Models
{
    public class Contexto:DbContext
    {


        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Carros> Carros { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Manutencao> Manutencao { get; set; }
        
    }
}
