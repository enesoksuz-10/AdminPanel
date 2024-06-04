using Microsoft.EntityFrameworkCore;
using NorthWND_DataAccessLayer.Context;
using NorthWND_Models.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWND_DataAccessLayer.Repository
{
    public class CategoryRepository
    {
        public List<Category> GetAllCategories(params string[] includeList)
        {
            using (NorthwndContext cnt = new NorthwndContext())
            {
                IQueryable<Category> dbSet = cnt.Categories;

                if (includeList != null && includeList.Length > 0)
                {
                    for (int i = 0; i < includeList.Length; i++)
                    {
                        dbSet = dbSet.Include(includeList[i]);
                    }
                }
                return dbSet.ToList();
            }

        }
    }
}
