using ArchPlay.Core.Entities;

namespace ArchPlay.Core.Interfaces;

public interface IUserService
{
    User CreateUser(
        string userName,
        string email
    );

    User? GetUserByUserName(string userName);
    User? GetUserById(Guid userId);
}