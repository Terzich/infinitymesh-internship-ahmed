using System;
using System.Collections.Generic;
using System.Text;
using RentaCar_Praksa.Dal.Domain;

namespace RentaCar_Praksa.Dal.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public void Authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }
        public UserRepository(RentaCarDbContext context):base(context)
        {

        }
    }
}
