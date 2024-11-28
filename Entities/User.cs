using System.ComponentModel.DataAnnotations;

namespace ApiUser.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public int Age { get; set; }
    }
}
