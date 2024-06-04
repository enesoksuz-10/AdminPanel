using NorthWND_DataAccessLayer.Repository;
using NorthWND_Models.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWND_BusinessLayer.Concreate
{
    public class SupplierBS
    {
        public List<Supplier> GetAllSuppilers(params string[] includeList)
        {
            var repo = new SupplierRepository();
            var sup = repo.GetAllSuppliers(includeList);
            return sup;
        }
    }
}
