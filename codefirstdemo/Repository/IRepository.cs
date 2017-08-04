using System;
namespace codefirstdemo.Repository
{
    interface IRepository<T>
     where T : class
    {
        void Delete(object Id);
        System.Collections.Generic.IEnumerable<T> GetAll();
        T GetById(object Id);
        void Insert(T obj);
        void Save();
        void Update(T obj);
    }
}
