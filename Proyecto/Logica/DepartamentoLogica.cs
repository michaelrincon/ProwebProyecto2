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

        public Proyecto.Models.Departamento GetDepartamentoById(int id)
        {
            try
            {
                var result = new DepartamentoRepositorio().GetDepartamentoById(id);
                return result;
            }
            catch (Exception)
            {
                return new Proyecto.Models.Departamento();
                //throw;
            }
        }

        public void Create(Proyecto.Models.Departamento departamento, int idpais)
        {
            try
            {
                new DepartamentoRepositorio().Create(departamento,idpais);
            }
            catch (Exception)
            {

                //throw;
            }
        }

        public void Update(Proyecto.Models.Departamento departamento)
        {
            try
            {
                new DepartamentoRepositorio().Update(departamento);
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
                new DepartamentoRepositorio().Delete(id);
            }
            catch (Exception)
            {

                //throw;
            }
        }
    }
}
