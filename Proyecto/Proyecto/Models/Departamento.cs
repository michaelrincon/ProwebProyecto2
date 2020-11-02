using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Proyecto.Models
{
    public class Departamento
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Nombre departamento")]
        public string NombreDepartamento { get; set; }
    }
}