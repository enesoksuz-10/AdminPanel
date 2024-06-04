using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWND_Models.Entities.Concreate
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public int CategoryId{ get; set; }
        public int SupplierId{ get; set; }
        public bool Discontinued { get; set; }
        public Category Category{ get; set; }
        public Supplier Supplier{ get; set; }
    }
}
