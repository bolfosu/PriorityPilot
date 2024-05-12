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

        public async Task<User> CreateAsync(UserCreationDto dto)
        {
            User? existing = await userDao.GetByUsername(dto.UserName);
            if (existing != null)
                throw new Exception("Username already taken!");

            ValidateData(dto);
            User toCreate = new User
            {
                UserName = dto.UserName
            };

            User created = await userDao.Create(toCreate);

            return created;
        }


    }

}
