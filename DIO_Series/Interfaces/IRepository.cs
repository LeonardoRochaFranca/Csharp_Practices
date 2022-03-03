using System.Collections.Generic;


namespace DIO_Series.Interfaces
{
    public interface IRepository<T>
    {
        List<T> List();
        T ReturnForId(int id);
        void Insert(T entity);
        void Delet(int id);
        void Update(int id, T entity);
        int NextId();

    }
}
