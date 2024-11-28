namespace ApiUser.Entities.Request
{
    public class CreateUserRequest
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public int Age { get; set; }
    }
}
