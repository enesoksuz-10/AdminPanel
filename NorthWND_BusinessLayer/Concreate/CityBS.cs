using NorthWND_DataAccessLayer.Repository;
using NorthWND_Models.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWND_BusinessLayer.Concreate
{
    public  class CityBS
    {
        public List<Sehir> GetAllCities (params string[] includeList)
        {
            var repo = new CityRepository();
            var cities = repo.GetCities(includeList);
            return cities;
        }
    }
}
