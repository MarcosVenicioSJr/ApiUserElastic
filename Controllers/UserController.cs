using ApiUser.Entities;
using ApiUser.Entities.Request;
using ApiUser.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiUser.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<User> users = _service.Get();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            User user = _service.GetById(id);

            if(user is null)
                return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateUserRequest request)
        {
            _service.Create(request);

            return Created();
        }
    }
}
