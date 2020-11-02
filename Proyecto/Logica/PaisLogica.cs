using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PaisLogica
    {
        public List<Proyecto.Models.Pais> GetPaises()
        {
            try
            {
                var listapaises = new PaisRepositorio().GetPaises();
                return listapaises;
            }
            catch (Exception)
            {
                return new List<Proyecto.Models.Pais>();
                //throw;
            }

        }
    }
}
