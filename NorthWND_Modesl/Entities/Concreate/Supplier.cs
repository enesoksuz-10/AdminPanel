using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWND_Models.Entities.Concreate
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string CompanyName{ get; set; }
        public string ContactName{ get; set; }
        public string City{ get; set; }
        public string Country { get; set; }
        public List<Product> Products { get; set; }
    }
}
