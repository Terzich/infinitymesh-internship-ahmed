using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RentaCar_Praksa.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RentaCar_Praksa.Dal.Repositories
{
    public class BaseRepository<TViewModel,TDatabase,TUpsertRequest> : IBaseRepository<TViewModel, TUpsertRequest> where TDatabase : BaseEntity
    {
        private protected readonly RentaCarDbContext _context;
        private protected readonly IMapper _mapper;


        public BaseRepository(RentaCarDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> Add(TUpsertRequest obj, CancellationToken cancellationToken = default)
        {
            var entity = _mapper.Map<TDatabase>(obj);
            await _context.Set<TDatabase>().AddAsync(entity,cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }

        public async Task<List<TViewModel>> GetAll(CancellationToken cancellationToken = default)
        {
            var collection = await _context.Set<TDatabase>().ToListAsync(cancellationToken);
            return _mapper.Map<List<TViewModel>>(collection);
        }

        public async Task<TViewModel> GetById(int id, CancellationToken cancellationToken = default)
        {
            var entity = await _context.Set<TDatabase>().FindAsync(id,cancellationToken);
            return _mapper.Map<TViewModel>(entity);
        }

        public async Task Update(int id, TUpsertRequest obj, CancellationToken cancellationToken = default)
        {
            var entity = await _context.Set<TDatabase>().FindAsync(id, cancellationToken);
            _context.Set<TDatabase>().Attach(entity);
            _context.Set<TDatabase>().Update(entity);
            _mapper.Map(obj, entity);
            await _context.SaveChangesAsync(cancellationToken);


        }
    }
}
