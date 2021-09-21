using Microsoft.EntityFrameworkCore;
using ProyectoCiclo3.App.Dominio;

namespace ProyectoCiclo3.App.Persistencia
{
    public class AppContext: DbContext{
        public DbSet<Aviones> Aviones { get; set; } // Repetir con la entidad Ruta y Aeropuerto
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ProyectoCiclo3");
            }
        }
    }
}