using Application.DaoInterfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UserCreationDto;

namespace Application.Logic
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserDao userDao;

        public UserLogic(IUserDao userDao)
        {
            this.userDao = userDao;
        }

        public Task<User> CreateAsync(UserCreationDto userToCreate)
        {
            throw new NotImplementedException();
        }
    }
}
