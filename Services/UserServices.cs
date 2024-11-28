using ApiUser.Entities;
using ApiUser.Entities.Request;
using ApiUser.Interfaces;
using ApiUser.Mapper;

namespace ApiUser.Services
{
    public class UserServices : IUserService
    {
        private readonly IUserRepository _repository;

        public UserServices(IUserRepository repository)
        {
            _repository = repository;
        }

        public void Create(CreateUserRequest request)
        {
            User user = UserMapper.MapperRequestToUser(request);
            _repository.Insert(user);
        }

        public List<User> Get()
        {
            return _repository.Get().Result;
        }

        public User GetById(int id)
        {
            return _repository.GetById(id).Result;
        }
    }
}
