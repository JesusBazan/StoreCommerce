using System;
using System.Collections.Generic;

namespace StoreCommerce.Models
{
    public partial class Productos
    {
        public int Idproducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal? Precio { get; set; }
        public int? Existencia { get; set; }
        public int? Idproveedor { get; set; }

        public virtual Proveedor IdproveedorNavigation { get; set; }
    }
}
