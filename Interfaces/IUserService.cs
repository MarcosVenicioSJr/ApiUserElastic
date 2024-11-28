using ApiUser.Entities;
using ApiUser.Entities.Request;

namespace ApiUser.Interfaces
{
    public interface IUserService
    {
        List<User> Get();
        User GetById(int id);
        void Create(CreateUserRequest user);
    }
}
