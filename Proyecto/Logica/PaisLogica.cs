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

        public List<Proyecto.Models.Departamento> GetDepartamentosPais(int id)
        {
            try
            {
                var listadepartamentos = new PaisRepositorio().GetDepartamentosPais(id);
                return listadepartamentos;
            }
            catch (Exception)
            {
                return new List<Proyecto.Models.Departamento>();
                //throw;
            }

        }

        public Proyecto.Models.Pais GetPaisById(int id)
        {
            try
            {
                var result = new PaisRepositorio().GetPaisById(id);
                return result;
            }
            catch (Exception)
            {
                return new Proyecto.Models.Pais();
                //throw;
            }
        }

        public void Create(Proyecto.Models.Pais pais)
        {
            try
            {
                new PaisRepositorio().Create(pais);
            }
            catch (Exception)
            {
               
                //throw;
            }
        }

        public void Update(Proyecto.Models.Pais pais)
        {
            try
            {
                new PaisRepositorio().Update(pais);
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
                new PaisRepositorio().Delete(id);
            }
            catch (Exception)
            {

                //throw;
            }
        }
    }
}
