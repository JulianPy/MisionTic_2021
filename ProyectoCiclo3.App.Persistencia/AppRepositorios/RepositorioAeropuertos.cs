using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAeropuertos
    {
        List<Aeropuertos> aeropuertos;
 
    public RepositorioAeropuertos()
        {
            aeropuertos= new List<Aeropuertos>()
            {
                new Aeropuertos{id=1, nombre="El Dorado", ciudad="Bogota", pais="Colombia", coord_x=2, coord_y=3},
                new Aeropuertos{id=2, nombre="Aero-cafe", ciudad="Manizales", pais="Colombia", coord_x=4, coord_y=5},
                new Aeropuertos{id=3, nombre="Ernesto Cortissoz", ciudad="Barranquilla", pais="Colombia", coord_x=6, coord_y=7}
            };
        }
 
        public IEnumerable<Aeropuertos> GetAll()
        {
            return aeropuertos;
        }
 
        public Aeropuertos GetAeropuertoWithId(int id){
            return aeropuertos.SingleOrDefault(b => b.id == id);
        }

        public Aeropuertos Update(Aeropuertos newAeropuerto){
            var aeropuerto= aeropuertos.SingleOrDefault(b => b.id == newAeropuerto.id);
            if(aeropuerto != null){
                aeropuerto.nombre = newAeropuerto.nombre;
                aeropuerto.ciudad = newAeropuerto.ciudad;
                aeropuerto.pais = newAeropuerto.pais;
                aeropuerto.coord_x = newAeropuerto.coord_x;
                aeropuerto.coord_y = newAeropuerto.coord_y;
            }
        return aeropuerto;
        }
        public Aeropuertos Create(Aeropuertos newAeropuerto)
        {
           if(aeropuertos.Count > 0){
           newAeropuerto.id=aeropuertos.Max(r => r.id) +1; 
            }else{
               newAeropuerto.id = 1; 
            }
           aeropuertos.Add(newAeropuerto);
           return newAeropuerto;
        }
        public Aeropuertos Delete(int id)
        {
            var aeropuerto= aeropuertos.SingleOrDefault(b => b.id == id);
            aeropuertos.Remove(aeropuerto);
            return aeropuerto;
        }
    }
}
