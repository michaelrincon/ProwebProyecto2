using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class DepartamentoRepositorio
    {
        public List<Proyecto.Models.Departamento> GetDepartamentos()
        {
            using (var context = new bdprowebEntities())
            {
                var listadepartamentos = context.Departamentos.Select(c => new Proyecto.Models.Departamento
                {
                    Id = c.Id,
                    NombreDepartamento = c.NombreDepartamento
                }).ToList();

                return listadepartamentos;
            }
        }
    }
}
