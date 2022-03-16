using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepository<T>
    {
        List <T> GetList();
        T ReturnById (int Id);
        void Insert(T entity);
        void Delete(int Id);
        void Update(int Id, T entity);
        int nextId();
    }
}

         