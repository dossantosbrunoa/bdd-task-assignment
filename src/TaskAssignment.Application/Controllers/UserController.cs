using Microsoft.AspNetCore.Mvc;
using TaskAssignment.Domain.Repositories.Interfaces;
using TaskAssignment.Domain.Responses;

namespace TaskAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUsersRepository _usersRepository;
        public UserController(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var usersList = await _usersRepository.GetAll();
            return Ok(usersList.Select(UserResponse.From));
        }
    }
}