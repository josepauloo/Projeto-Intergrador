using Microsoft.EntityFrameworkCore;
using PI.Data.Mapeamento;
using PI.Models;

namespace PI.Data
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMapeamento());
        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Login> Login { get; set; }
    }
}
