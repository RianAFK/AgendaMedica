
using AgendaMedica.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AgendaMedica.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Agenda> Agenda { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Aqui, nós dizemos como irá se chamar a tabela no banco de dados
            base.OnModelCreating(builder);
            builder.Entity<Especialidade>().ToTable("Especialidade");
            builder.Entity<Medico>().ToTable("Medicos");
            builder.Entity<Paciente>().ToTable("Pacientes");
            builder.Entity<Agenda>().ToTable("Agenda");
            //Depois que você cria, você pode adicionar ao banco de dados utilizando as migrations do Entity Framework
        }
    }
}
