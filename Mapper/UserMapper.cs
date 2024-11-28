using ApiUser.Entities;
using ApiUser.Entities.Request;

namespace ApiUser.Mapper
{
    public static class UserMapper
    {
        public static User MapperRequestToUser(CreateUserRequest request)
        {
            return new User
            {
                Name = request.Name,
                Mail = request.Mail,
                Age = request.Age
            };
        }
    }
}
