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

        public List<Proyecto.Models.Ciudad> GetCiudadesDepartamento(int id)
        {
            try
            {
                var listaciudades = new CiudadRepositorio().GetCiudadesDepartamento(id);
                return listaciudades;
            }
            catch (Exception)
            {
                return new List<Proyecto.Models.Ciudad>();
                //throw;
            }
        }

        public Proyecto.Models.Ciudad GetCiudadById(int id)
        {
            try
            {
                var result = new CiudadRepositorio().GetCiudadById(id);
                return result;
            }
            catch (Exception)
            {
                return new Proyecto.Models.Ciudad();
                //throw;
            }
        }

        public void Create(Proyecto.Models.Ciudad ciudad, int iddep)
        {
            try
            {
                new CiudadRepositorio().Create(ciudad, iddep);
            }
            catch (Exception)
            {

                //throw;
            }
        }

        public void Update(Proyecto.Models.Ciudad ciudad)
        {
            try
            {
                new CiudadRepositorio().Update(ciudad);
            }
            catch (Exception)
            {

                //throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                new CiudadRepositorio().Delete(id);
            }
            catch (Exception)
            {

                //throw;
            }
        }
    }
}
