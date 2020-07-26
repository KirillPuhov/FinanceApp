using System;
using System.Collections.Generic;

namespace FinanceApp.BL.Controller
{
    public class ControllerBase
    {
        private readonly IDataSaver manager = new DatabaseSaver();

        protected void Save<T>(T item) where T : class
        {
            manager.Save(item);
        }

        protected List<T> GetAllArticles<T>() where T : class
        {
            return manager.Load<T>();
        }

        protected void Remove<T>(int Id) where T : class
        {
            manager.Remove<T>(Id);
        }
    }
}
