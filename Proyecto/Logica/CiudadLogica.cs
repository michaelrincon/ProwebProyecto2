using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CiudadLogica
    {
        public List<Proyecto.Models.Ciudad> GetCiudades()
        {
            try
            {
                var listaciudades = new CiudadRepositorio().GetCiudades();
                return listaciudades;
            }
            catch (Exception)
            {
                return new List<Proyecto.Models.Ciudad>();
                //throw;
            }

        }
    }
}
