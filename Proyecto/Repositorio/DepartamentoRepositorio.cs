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
            using (var context = new bdprowebEntities1())
            {
                var listadepartamentos = context.Departamentos.Select(c => new Proyecto.Models.Departamento
                {
                    Id = c.Id,
                    NombreDepartamento = c.NombreDepartamento
                }).ToList();

                return listadepartamentos;
            }
        }

        public List<Proyecto.Models.Departamento> GetDepartamentosPais(int id)
        {
            using (var context = new bdprowebEntities1())
            {
                var listadepartamentos = context.Departamentos.Where(c => c.PaisId == id)
                    .Select(c =>
                        new Proyecto.Models.Departamento
                        {
                            Id = c.Id,
                            NombreDepartamento = c.NombreDepartamento
                        }).ToList();

                return listadepartamentos;
            }
        }

        public Proyecto.Models.Departamento GetDepartamentoById(int id)
        {
            using (var context = new bdprowebEntities1())
            {
                var result = context.Departamentos.Where(c => c.Id == id)
                    .Select(c =>
                        new Proyecto.Models.Departamento
                        {
                            Id = c.Id,
                            NombreDepartamento = c.NombreDepartamento
                        }).FirstOrDefault();

                return result;
            }
        }

        public void Create(Proyecto.Models.Departamento departamento, int idpais)
        {
            var entidad = new Departamento
            {
                Id = departamento.Id,
                NombreDepartamento = departamento.NombreDepartamento,
                PaisId = idpais
            };
            using (var context = new bdprowebEntities1())
            {
                context.Departamentos.Add(entidad);
                context.SaveChanges();

            }
        }

        public void Update(Proyecto.Models.Departamento departamento)
        {
            using (var context = new bdprowebEntities1())
            {
                var entidad = context.Departamentos.Find(departamento.Id);

                entidad.NombreDepartamento = departamento.NombreDepartamento;

                context.SaveChanges();

            }

        }

        public void Delete(int id)
        {
            using (var context = new bdprowebEntities1())
            {
                var entidad = context.Departamentos.Find(id);
                context.Departamentos.Remove(entidad);
                context.SaveChanges();

            }
        }
    }
}
