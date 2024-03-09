using ArchPlay.Core.Entities;

namespace ArchPlay.Core.Repositories;

public interface IUserRepository
{
    User Add(string username, string email);
    User GetUserById(Guid id);
    User GetUserByName(string username);
    User GetUserByEmail(string email);
}