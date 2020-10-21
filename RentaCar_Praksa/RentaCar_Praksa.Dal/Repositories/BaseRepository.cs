using RentaCar_Praksa.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar_Praksa.Dal.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private protected readonly RentaCarDbContext _context;

        public BaseRepository(RentaCarDbContext context)
        {
            _context = context;
        }
        public T Add(T obj)
        {
            _context.Add(obj);
            return obj;

        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, T obj)
        {
            throw new NotImplementedException();
        }
    }
}
