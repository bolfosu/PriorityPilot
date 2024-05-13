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

        private static void ValidateData(UserCreationDto userToCreate)
        {
            string userName = userToCreate.UserName;

            if (userName.Length < 3)
                throw new Exception("Username must be at least 3 characters!");

            if (userName.Length > 15)
                throw new Exception("Username must be less than 16 characters!");
        }


    }

}
