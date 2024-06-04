using NorthWND_DataAccessLayer.Repository;
using NorthWND_Models.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWND_BusinessLayer.Concreate
{
    public class CategoryBS
    {
        public List<Category> GetAllCategories(params string[] includeList)
        {
            var repo = new CategoryRepository();
            var cat = repo.GetAllCategories(includeList);
            return cat;
        }
    }
}
