using NorthWND_Models.Entities.Concreate;

namespace NorthWND_UI.Areas.AdminPanel.Models
{
    public class EmployeeIndexViewModel
    {
        public List<Employee> ListEmployee{ get; set; }
        public List<Sehir> Cities { get; set; }
    }
}
