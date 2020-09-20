using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreCommerce.Models;

namespace StoreCommerce.Controllers
{
    [Route("api/[controller]")]
    public class ProvedorController : Controller
    {
        private Models.storecommerceContext db = new Models.storecommerceContext();
        public ProvedorController()
        {
            
        }
        [HttpGet("[action]")]
        public IEnumerable<Proveedor> ProvedoresList()
        {
            List<Proveedor> proveedores = (from d in db.Proveedor
                                           select new Proveedor
                                           {
                                               Idproveedor = d.Idproveedor,
                                               Proveedor1 = d.Proveedor1,
                                               Telefono = d.Telefono,
                                               Direccion = d.Direccion
                                           }).ToList();
            return proveedores;
        }
    }
}
