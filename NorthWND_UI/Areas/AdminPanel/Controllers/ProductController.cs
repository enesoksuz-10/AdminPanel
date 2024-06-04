using Microsoft.AspNetCore.Mvc;
using NorthWND_BusinessLayer.Concreate;
using NorthWND_Models.Entities.Concreate;
using NorthWND_UI.Areas.AdminPanel.ActionFilter;
using NorthWND_UI.Areas.AdminPanel.Models;

namespace NorthWND_UI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [CheckLogInSession]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            var model = new ProductIndexModel();

            var bs = new ProductBS();
            var cbs = new CategoryBS();
            var sbs = new SupplierBS();


            var products = bs.GetAllProducts("Category","Supplier");
            var categories = cbs.GetAllCategories();
            var suppliers = sbs.GetAllSuppilers();

            model.Products = products;
            model.Categories = categories;
            model.Suppliers = suppliers;
            return View(model);
        }

        [HttpPost]

        public JsonResult AddProduct(ProductAddDTO dto)
        {

            if (dto.CategoryId == 0 || dto.CategoryId ==-1)
            {
                return Json(new { Result = false, Message = "Kategori Kısımı Boş Geçilemez." });
            }
            if (dto.SupplierId == 0 || dto.SupplierId == -1)
            {
                return Json(new { Result = false, Message = "Tedarikçi Kısımı Boş Geçilemez." });
            }


            var product = new Product();
            product.ProductName = dto.ProductName;
            product.UnitPrice = dto.UnitPrice;
            product.UnitsInStock = dto.UnitsInStock;
            product.CategoryId = dto.CategoryId;
            product.SupplierId = dto.SupplierId;
            product.Discontinued = dto.Discontinued;

            // Dto Nesne Mapping
            // Bs ye Add fonk. gönder --> dataAccess(repo) 
            // Sonucuna göre uyarı ver
            var productBS = new ProductBS();
            var insertedProduct = productBS.AddProduct(product);

            if (insertedProduct != null)
            {
                return Json(new { Result = true ,BasariliMi=true, Message ="Ürün Başarılı bir şekilde Kayıt Edildi."});
            }
            else
            {
                return Json(new { Result = false, BasariliMi = false, Message = "Kayıt Esnasında bir sorun oldu." });

            }
          

        }

        [HttpPost]

        public JsonResult DeleteProduct(int id)
        {
            if (id<=0)
            {
                return Json(new { Result = false, Message ="Silme İşlemi esneasında bir sorun ile karşılaşıldı." });
            }
            var productBs = new ProductBS();
            productBs.Delete(id);
            return Json(new { Result = true, Message="Ürün Silindi." });
        }

        public JsonResult GetProductById(int id)
        {
            if (id <= 0)
            {
                return Json(new { Result = false, Message = "Silme İşlemi esneasında bir sorun ile karşılaşıldı." });
            }
            var productBs = new ProductBS();
            var product = productBs.GetById(id);
            return Json(new { Result = true, Message = "Ürün Silindi." ,Product = product });
        }
        [HttpPost]
        public JsonResult EditProduct(ProductUpdateDto dto)
        {
            var productBs = new ProductBS();

            var productOrjinal = productBs.GetById(dto.ProductId);
            productOrjinal.UnitPrice = dto.UnitPrice;
            productOrjinal.UnitsInStock= dto.UnitsInStock;
            productOrjinal.ProductName= dto.ProductName;

           var updateProduct= productBs.Update(productOrjinal);
            if (updateProduct != null)
            {
                return Json(new { Result = true, Message = "Ürün Başarılı bir şekilde güncellendi." });
            }
            else
            {
                return Json(new { Result = false, Message = "Ürün Güncellenemedi." });
            }

        }
    }
}
