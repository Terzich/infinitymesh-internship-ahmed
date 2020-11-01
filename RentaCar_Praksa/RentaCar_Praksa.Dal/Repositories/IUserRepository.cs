using RentaCar_Praksa.Dal.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RentaCar_Praksa.Dal.Repositories
{
    public interface IUserRepository
    {
        Task<UserViewModel> GetUsers(CancellationToken cancellationToken = default);
        Task<int> SaveUser(UserDto user, CancellationToken cancellationToken = default);
        Task EditUser(int userId, UserDto car, CancellationToken cancellationToken = default);
        Task RemoveUser(int userId, CancellationToken cancellationToken = default);
    }
}
