using Microsoft.EntityFrameworkCore;
using WebApiExamen1.Models;

namespace WebApiExamen1.Data
{
    public class PersonajesContext : DbContext
    {
        public PersonajesContext(DbContextOptions<PersonajesContext> options) : base(options) { }

        public DbSet<PersonajeSeries> PersonajesSeries { get; set; }
    }
}
