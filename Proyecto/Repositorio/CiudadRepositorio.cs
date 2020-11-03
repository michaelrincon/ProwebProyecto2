using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class CiudadRepositorio
    {
        public List<Proyecto.Models.Ciudad> GetCiudades()
        {
            using (var context = new bdprowebEntities1())
            {
                var listaciudades = context.Ciudades.Select(c => new Proyecto.Models.Ciudad
                {
                    Id = c.Id,
                    NombreCiudad = c.NombreCiudad
                }).ToList();

                return listaciudades;
            }
        }

        public List<Proyecto.Models.Ciudad> GetCiudadesDepartamento(int id)
        {
            using (var context = new bdprowebEntities1())
            {
                var listaciudades = context.Ciudades.Where(c => c.DepartamentoId == id)
                    .Select(c =>
                        new Proyecto.Models.Ciudad
                        {
                            Id = c.Id,
                            NombreCiudad = c.NombreCiudad
                        }).ToList();

                return listaciudades;
            }
        }

        public Proyecto.Models.Ciudad GetCiudadById(int id)
        {
            using (var context = new bdprowebEntities1())
            {
                var result = context.Ciudades.Where(c => c.Id == id)
                    .Select(c =>
                        new Proyecto.Models.Ciudad
                        {
                            Id = c.Id,
                            NombreCiudad = c.NombreCiudad
                        }).FirstOrDefault();

                return result;
            }
        }

        public void Create(Proyecto.Models.Ciudad ciudad, int iddep)
        {
            var entidad = new Ciudade
            {
                Id = ciudad.Id,
                NombreCiudad = ciudad.NombreCiudad,
                DepartamentoId = iddep
            };
            using (var context = new bdprowebEntities1())
            {
                context.Ciudades.Add(entidad);
                context.SaveChanges();

            }
        }

        public void Update(Proyecto.Models.Ciudad ciudad)
        {
            using (var context = new bdprowebEntities1())
            {
                var entidad = context.Ciudades.Find(ciudad.Id);

                entidad.NombreCiudad = ciudad.NombreCiudad;

                context.SaveChanges();

            }

        }

        public void Delete(int id)
        {
            using (var context = new bdprowebEntities1())
            {
                var entidad = context.Ciudades.Find(id);
                context.Ciudades.Remove(entidad);
                context.SaveChanges();

            }
        }
    }
}
