using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWND_Models.Entities.Concreate
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName{ get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
}
