using System;
using System.Collections.Generic;

namespace FinanceApp.BL.Controller
{
    public interface IDataSaver
    {
        void Save<T>(T item) where T : class;
        void Remove<T>(int Id) where T : class;
        List<T> Load<T>() where T : class;
    }
}
