using NorthWND_DataAccessLayer.Repository;
using NorthWND_Models.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWND_BusinessLayer.Concreate
{
    public  class ProductBS
    {
        public List<Product> GetAllProducts(params string[] includeList)
        {
            var repo = new ProductRepository();
            var products = repo.GetAllProducts(includeList);
            return products;
        }

        public Product GetById(int id)
        {
            var repo = new ProductRepository();
            var products = repo.GetById(id);
            return products;
        }
        public Product AddProduct(Product product)
        {
            var repo = new ProductRepository();
            var products = repo.Add(product);
            return products;
        }
        public void Delete(int id)
        {
            var repo = new ProductRepository();
            repo.Delete(id);
           
        }
        public Product Update(Product product)
        {
            var repo = new ProductRepository();
            var products = repo.Update(product);
            return products;
        }
    }
}
