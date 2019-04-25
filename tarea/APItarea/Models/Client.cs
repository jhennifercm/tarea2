using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APItarea.Models
{
    public class Client
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
    }
}