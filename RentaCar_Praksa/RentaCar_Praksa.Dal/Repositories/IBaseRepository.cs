using RentaCar_Praksa.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RentaCar_Praksa.Dal.Repositories
{
    public interface IBaseRepository<TViewModel,TUpsertRequest> 
    {
        Task<TViewModel> GetById(int id, CancellationToken cancellationToken = default);
        Task<List<TViewModel>> GetAll(CancellationToken cancellationToken = default);
        Task<int> Add(TUpsertRequest obj, CancellationToken cancellationToken = default);
        Task Update(int id, TUpsertRequest obj, CancellationToken cancellationToken = default);
    }
}
