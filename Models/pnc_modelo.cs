using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class pnc_modelo
    {
        [Key]
        public int Idpnc { get; set; }
        public DateTime fecha_registro { set; get; }
        public string nombre_proceso { get; set; }
        public string producto { get; set; }
        public int accion_inmediata { get; set; }
        public int accion_correctiva { set; get; }
        public string descripcion_accion { set; get; }
        
    }
}
