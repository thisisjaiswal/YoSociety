using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YoSociety.Entities;

namespace YoSociety.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(string filter);
        IEnumerable<T> Search(string filter);
        T Get(string id);
        T Add(T item);        
        bool Update(T item);
        void Remove(string id);
    }
}
