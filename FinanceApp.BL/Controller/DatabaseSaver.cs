using System;
using System.Collections.Generic;
using System.Linq;

namespace FinanceApp.BL.Controller
{
    public class DatabaseSaver : IDataSaver
    {
        public List<T> Load<T>() where T : class
        {
            List<T> item;

            using (var db = new FinanceContext())
            {
                item = db.Set<T>().Where(i => true).ToList();
            }
            return item;
        }

        public void Remove<T>(int Id) where T : class
        {
            using (var db = new FinanceContext())
            {
                var result = db.Set<T>().Find(Id);
                db.Set<T>().Remove(result);
                db.SaveChanges();
            }
        }

        public void Save<T>(T item) where T : class
        {
            using (var db = new FinanceContext())
            {
                db.Set<T>().Add(item);
                db.SaveChanges();
            }
        }
    }
}
