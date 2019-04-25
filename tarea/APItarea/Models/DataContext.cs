using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APItarea.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {
                
        }

        public System.Data.Entity.DbSet<MVCtarea.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<MVCtarea.Models.Venta> Ventas { get; set; }

        public System.Data.Entity.DbSet<MVCtarea.Models.Client> Clients { get; set; }
    }
}