using Microsoft.EntityFrameworkCore;
using NorthWND_DataAccessLayer.Context;
using NorthWND_Models.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWND_DataAccessLayer.Repository
{
    public  class CityRepository
    {
        public List<Sehir> GetCities(params string[] includeList)
        {
            using (NorthwndContext cnt = new NorthwndContext())
            {
                IQueryable<Sehir> dbSet = cnt.Sehirler;

                if (includeList != null && includeList.Length > 0)
                {
                    for (int i = 0; i < includeList.Length; i++)
                    {
                        dbSet = dbSet.Include(includeList[i]);
                    }
                }
                return dbSet.OrderBy(x=>x.SehirAdi).ToList();
            }

        }
    }
}
