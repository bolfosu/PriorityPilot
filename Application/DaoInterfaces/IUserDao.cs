using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DaoInterfaces
{
    internal interface IUserDao
    {
        Task<User> CreateAsync(User user);
        Task<User?> GetByUsernameAsync(string userName);
    }
}
