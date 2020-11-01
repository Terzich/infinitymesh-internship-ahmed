using Microsoft.EntityFrameworkCore;
using RentaCar_Praksa.Dal.Domain;
using RentaCar_Praksa.Dal.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RentaCar_Praksa.Dal.Repositories
{
    public class SqlServerUserRepository : IUserRepository
    {
        private readonly RentaCarDbContext _context;
        public SqlServerUserRepository(RentaCarDbContext context)
        {
            _context = context;
        }
        public async Task EditUser(int userId, UserDto user, CancellationToken cancellationToken = default)
        {
            var userDomain = await _context.Users.FindAsync(userId);
            userDomain.Name = user.Name;
            userDomain.Surname = user.Surname;
            userDomain.DateOfBirth = user.DateOfBirth;
            userDomain.CityID = user.CityID;
            userDomain.Address = user.Address;
            userDomain.Username = user.Username;
            userDomain.Email = user.Email;
            userDomain.Password = user.Password;
            _context.Users.Update(userDomain);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<UserViewModel> GetUsers(CancellationToken cancellationToken = default)
        {
            var collection = await _context.Users.ToListAsync(cancellationToken);
            return new UserViewModel(collection);
        }

        public Task RemoveUser(int userId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<int> SaveUser(UserDto user, CancellationToken cancellationToken = default)
        {
            var userDomain = new User
            {
                Name = user.Name,
                Surname = user.Surname,
                DateOfBirth = user.DateOfBirth,
                Address = user.Address,
                Email = user.Email,
                Password = user.Password,
                CityID = user.CityID,
                Username=user.Username
            };
            await _context.Users.AddAsync(userDomain, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return userDomain.Id;
        }
    }
}
