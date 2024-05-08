using Domain;
using System;

public class UserCreationDto
{
    public string UserName { get; }

    public UserCreationDto(string userName)
    {
        UserName = userName;
    }
    public interface IUserLogic
    {
        Task<User> CreateAsync(UserCreationDto userToCreate);
    }
}
