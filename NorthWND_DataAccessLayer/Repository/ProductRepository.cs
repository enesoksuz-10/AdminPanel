using Microsoft.EntityFrameworkCore;
using NorthWND_DataAccessLayer.Context;
using NorthWND_Models.Entities.Concreate;

namespace NorthWND_DataAccessLayer.Repository
{
    public class ProductRepository
    {

        // "Category"
        public List<Product> GetAllProducts(params string[] includeList)
        {
            using (NorthwndContext cnt = new NorthwndContext())
            {
                IQueryable<Product> dbSet = cnt.Products;

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
        public Product GetById(int id)
        {
            using (NorthwndContext cnt = new NorthwndContext())
            {
                var prd = cnt.Products.SingleOrDefault(x => x.ProductId == id);
                return prd;
            }

        }

        public Product Add(Product product)
        {
            using (NorthwndContext cnt = new NorthwndContext())
            {
                var prd = cnt.Products.Add(product);
                cnt.SaveChanges();
                return prd.Entity;
            }

        }
        public Product Update(Product product)
        {
            using (NorthwndContext cnt = new NorthwndContext())
            {
                var prd = cnt.Products.Update(product);
                cnt.SaveChanges();
                return prd.Entity;
            }

        }
        public void Delete(int id)
        {
            using (NorthwndContext cnt = new NorthwndContext())
            {
                var prd = GetById(id);
                cnt.Products.Remove(prd);
                cnt.SaveChanges();
              
            }

        }
        // Add - Delete - Update


    }
}
