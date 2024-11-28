using ApiUser.Entities;

namespace ApiUser.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> Get();
        Task<User> GetById(int id);
        Task Insert(User user);
    }
}
