using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Formulario
    {
        [Key]
        public  int PuestoID { get; set; }
        public string Puesto { get; set; }
        public string Requesitos { get; set; }
        public string Atribuciones { get; set; }


    }
}
