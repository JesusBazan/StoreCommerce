using System;
using System.Collections.Generic;

namespace StoreCommerce.Models
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            Productos = new HashSet<Productos>();
        }

        public int Idproveedor { get; set; }
        public string Proveedor1 { get; set; }
        public long? Telefono { get; set; }
        public string Direccion { get; set; }

        public virtual ICollection<Productos> Productos { get; set; }
    }
}
