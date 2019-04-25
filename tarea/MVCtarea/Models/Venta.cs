using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCtarea.Models
{
    public class Venta
    {
        [Key]
        public int VentaId { get; set; }
        public int ProductoId { get; set; }
        public int ClienteId { get; set; }
        public int fecha { get; set; }
    }
}