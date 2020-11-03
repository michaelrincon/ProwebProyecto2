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
            using (var context = new bdprowebEntities1())
            {
                var listapaises = context.Paises.Select(c => new Proyecto.Models.Pais
                {
                    Id = c.Id,
                    NombrePais = c.NombrePais
                }).ToList();

                return listapaises;
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

        public Proyecto.Models.Pais GetPaisById(int id)
        {
            using (var context = new bdprowebEntities1())
            {
                var result = context.Paises.Where(c => c.Id == id)
                    .Select(c =>
                        new Proyecto.Models.Pais
                        {
                            Id = c.Id,
                            NombrePais = c.NombrePais
                        }).FirstOrDefault();

                return result;
            }
        }

        public void Create(Proyecto.Models.Pais pais)
        {
            var entidad = new Pais
            {
                Id = pais.Id,
                NombrePais = pais.NombrePais
            };
            using (var context = new bdprowebEntities1())
            {
                context.Paises.Add(entidad);
                context.SaveChanges();

            }
        }

        public void Update(Proyecto.Models.Pais pais)
        {
            using (var context = new bdprowebEntities1())
            {
                var entidad = context.Paises.Find(pais.Id);

                entidad.NombrePais = pais.NombrePais;

                context.SaveChanges();

            }
            
        }

        public void Delete(int id)
        {
            using (var context = new bdprowebEntities1())
            {
                var entidad = context.Paises.Find(id);
                context.Paises.Remove(entidad);
                context.SaveChanges();

            }
        }

    }
}
