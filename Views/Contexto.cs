using Teste.Models;
using Microsoft.EntityFrameworkCore;

namespace Teste
{
    public class Contexto : DbContext
    {
        public DbSet<Paciente> Paciente { get; set; }

        public DbSet<Caloria_v3> Caloria_v3 { get; set; }

        public DbSet<NUTRICIONISTA> NUTRICIONISTA { get; set; }



        public Contexto()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=AppNutri;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            optionsBuilder.UseLazyLoadingProxies();
        }

       
    }
}