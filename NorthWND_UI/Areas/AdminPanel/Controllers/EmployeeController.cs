using Microsoft.AspNetCore.Mvc;
using NorthWND_BusinessLayer.Concreate;
using NorthWND_Models.Entities.Concreate;
using NorthWND_UI.Areas.AdminPanel.ActionFilter;
using NorthWND_UI.Areas.AdminPanel.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace NorthWND_UI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [CheckLogInSession]
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            var empBS = new EmployeeBS();
            var citBs = new CityBS();
            var model = new EmployeeIndexViewModel();

            model.ListEmployee = empBS.GetAll("Manager");
            model.Cities = citBs.GetAllCities();
            return View(model);
        }


        [HttpPost]
        public JsonResult AddEmployee(IFormFile selectedFile,EmployeeAddDTO dto)
        {
            var randomFiles = "";
            if (selectedFile !=null)
            {
                if (selectedFile.ContentType.StartsWith("image/"))
                {
                    if (!(selectedFile.Length>1024*1024))
                    {
                         randomFiles = Guid.NewGuid() + Path.GetExtension(selectedFile.FileName);
                         var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\adminPanel\dist\img\empimages\", randomFiles);
                        using (var stream = System.IO.File.Create(filePath))
                        {
                            selectedFile.CopyTo(stream);
                        }
                    
                    }
                }
            }
            var employee = new Employee();
            employee.FirstName = dto.FirstName;
            employee.LastName = dto.LastName;
            employee.Title = dto.Title;
            employee.BirthDate = dto.BirthDate;
            employee.HireDate = dto.HireDate;
            employee.City= dto.City;
            employee.Country = dto.Country;
            employee.PhotoPath = "\\adminPanel\\dist\\img\\empimages\\"+randomFiles;


            var employeeBS = new EmployeeBS();

            var insertedEmployee = employeeBS.AddEmployee(employee);

            if (insertedEmployee != null)
            {
                return Json(new { Result = true, BasariliMi = true, Message = "Ürün Başarılı bir şekilde Kayıt Edildi." });
            }
            else
            {
                return Json(new { Result = false, BasariliMi = false, Message = "Kayıt Esnasında bir sorun oldu." });

            }

        }
    }
}
