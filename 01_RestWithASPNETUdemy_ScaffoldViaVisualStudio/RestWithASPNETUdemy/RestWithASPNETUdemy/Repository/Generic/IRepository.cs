using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context.Base;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);

        T FindById(long id);
        
        List<T> FindAll();
        
        T Update(T item);
        
        void Delete(long Id);
        
        bool Exists(long id);
    }
}

