using Microsoft.EntityFrameworkCore;
using Planificador.Shared.Entities;

namespace Planificador.Backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Recurso> Recursos { get; set; }
        public DbSet<Actividad> Actividades { get; set; }
        public DbSet<HorarioCorte> HorariosCortes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<Notificacion> Notificaciones { get; set; }
        public DbSet<Configuracion> Configuraciones { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Actividad>()
                .HasIndex(x => x.NombreActividad)
                .IsUnique();
        }
    }
}