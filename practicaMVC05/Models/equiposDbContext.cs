using Microsoft.EntityFrameworkCore;
using practicaMVC05.Models;

namespace practicaMVC05.Models
{
    public class equiposDbContext : DbContext
    {
        public equiposDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<marcas> marcas { get; set; }
        public DbSet<estados_equipo> estados_equipo { get; set; }
        public DbSet<practicaMVC05.Models.estados_reserva>? estados_reserva { get; set; }
        public DbSet<practicaMVC05.Models.facultades>? facultades { get; set; }
        public DbSet<practicaMVC05.Models.tipo_equipo>? tipo_equipo { get; set; }
        public DbSet<practicaMVC05.Models.usuarios>? usuarios { get; set; }
        public DbSet<practicaMVC05.Models.carreras>? carreras { get; set; }
    }
}
