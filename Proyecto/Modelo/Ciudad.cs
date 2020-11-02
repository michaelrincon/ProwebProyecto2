using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Proyecto.Models
{
    public class Ciudad
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Nombre ciudad")]
        public string NombreCiudad { get; set; }
    }
}