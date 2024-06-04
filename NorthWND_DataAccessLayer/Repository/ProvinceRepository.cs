
using NorthWND_DataAccessLayer.Context;
using NorthWND_Models.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWND_DataAccessLayer.Repository
{
    public class ProvinceRepository
    {
        public List<Ilce> GetByCities(int id)
        {
            using (NorthwndContext cnt = new NorthwndContext())
            {
                IQueryable<Ilce> dbSet = cnt.Ilceler;



                return dbSet.Where(x => x.SehirId == id).ToList();
            }
        }

    }
}

