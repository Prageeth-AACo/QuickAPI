using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeFirst.Data
{
    public class DataManager<T> where T : class
    {
        private StudentContext context { get; set; }
        private readonly IDbSet<T> dbset;

        public DataManager()
        {
            context = new StudentContext();
            dbset = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return dbset.AsEnumerable();
        }

        public void Insert(T entity)
        {
            dbset.Add(entity);
            context.SaveChanges();
        }
    }
}
