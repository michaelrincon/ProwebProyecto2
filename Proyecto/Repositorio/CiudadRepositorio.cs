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
            using (var context = new bdprowebEntities())
            {
                var listaciudades = context.Ciudades.Select(c => new Proyecto.Models.Ciudad
                {
                    Id = c.Id,
                    NombreCiudad = c.NombreCiudad
                }).ToList();

                return listaciudades;
            }
        }
    }
}
