using ArchPlay.Core.Entities;
using ArchPlay.Core.Interfaces;
using ArchPlay.Core.Repositories;

namespace ArchPlay.Core.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(
        IUserRepository userRepository
        )
    {
        _userRepository = userRepository;
    }

    public User CreateUser(
        string userName,
        string email
    )
    {
        if (string.IsNullOrWhiteSpace(userName))
        {
            throw new ArgumentNullException(nameof(userName));
        }

        if (string.IsNullOrWhiteSpace(email))
        {
            throw new ArgumentNullException(nameof(email));
        }

        var user = _userRepository.Add(userName, email);

        return user;

    }

    public User? GetUserByUserName(string userName)
    {
        var user = _userRepository.GetUserByName(userName);
        if (user == null)
        {
            return null;
        }

        return user;
    }

    public User? GetUserById(Guid userId)
    {
        var user = _userRepository.GetUserById(userId);
        if (user == null)
        {
            return null;
        }

        return user;
    }
}