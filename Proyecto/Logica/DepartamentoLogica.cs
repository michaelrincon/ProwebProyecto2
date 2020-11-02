using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class DepartamentoLogica
    {
        public List<Proyecto.Models.Departamento> GetDepartamentos()
        {
            try
            {
                var listadepartamentos = new DepartamentoRepositorio().GetDepartamentos();
                return listadepartamentos;
            }
            catch (Exception)
            {
                return new List<Proyecto.Models.Departamento>();
                //throw;
            }

        }
    }
}
