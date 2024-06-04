using NorthWND_Models.Entities.Concreate;

namespace NorthWND_UI.Areas.AdminPanel.Models
{
    public class ProductIndexModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories{ get; set; }
        public List<Supplier> Suppliers{ get; set; }
    }
}
