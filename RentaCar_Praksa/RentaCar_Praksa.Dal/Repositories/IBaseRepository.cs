using RentaCar_Praksa.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar_Praksa.Dal.Repositories
{
    public interface IBaseRepository<T> where T:BaseEntity
    {
        T GetById(int id);
        List<T> GetAll();
        T Add(T obj);
        void Update(int id, T obj);
    }
}
