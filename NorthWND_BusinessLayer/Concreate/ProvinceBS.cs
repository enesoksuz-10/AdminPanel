using NorthWND_DataAccessLayer.Repository;
using NorthWND_Models.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWND_BusinessLayer.Concreate
{
    public class ProvinceBS
    {
        public List<Ilce> GetByCities(int id)
        {
            var repo = new ProvinceRepository();
            var provinces = repo.GetByCities(id);
            return provinces;
        }
    }
}
