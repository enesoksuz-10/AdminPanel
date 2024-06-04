namespace NorthWND_UI.Areas.AdminPanel.Models
{
    public class ProductUpdateDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public bool Discontinued { get; set; }
    }
}
