using Application.DaoInterfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData.DAOs
{
    public class UserFileDao : IUserDao
    {
        private readonly FileContext context;

        public UserFileDao(FileContext context)
        {
            this.context = context;
        }

        public Task<User> CreateAsync(User user)
        {

            int userId = 1;
            if (context.Users.Any())
            {
                userId = context.Users.Max(u => u.Id);
                userId++;
            }

            user.Id = userId;

            context.Users.Add(user);
            context.SaveChanges();

            return Task.FromResult(user);
        }

        public Task<User?> GetByUsernameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAsync(SearchUserParametersDto searchParameters)
        {
            IEnumerable<User> users = context.Users.AsEnumerable();
            if (searchParameters.UsernameContains != null)
            {
                users = context.Users.Where(u => u.UserName.Contains(searchParameters.UsernameContains, StringComparison.OrdinalIgnoreCase));
            }

            return Task.FromResult(users);
        }

    }
}
