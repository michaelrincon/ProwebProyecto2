using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class PaisRepositorio
    {
        public List<Proyecto.Models.Pais> GetPaises()
        {
            using (var context = new bdprowebEntities())
            {
                var listapaises = context.Paises.Select(c => new Proyecto.Models.Pais
                {
                    Id = c.Id,
                    NombrePais = c.NombrePais
                }).ToList();

                return listapaises;
            }
        }
    }
}
