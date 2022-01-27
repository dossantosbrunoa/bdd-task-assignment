using Microsoft.AspNetCore.Mvc;
using TaskAssignment.Domain.Repositories.Interfaces;
using TaskAssignment.Domain.Requests;
using TaskAssignment.Domain.Responses;
using TaskAssignment.Domain.Services.Interfaces;

namespace TaskAssignment.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserTaskController : ControllerBase
    {
        private readonly IUserTaskService _userTaskService;
        private readonly IUserTasksRepository _userTasksRepository;

        public UserTaskController(IUserTaskService userTaskService,
            IUserTasksRepository userTasksRepository)
        {
            _userTaskService = userTaskService;
            _userTasksRepository = userTasksRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]UserTaskAddRequest userTaskAddRequest)
        {
            var id = await _userTaskService.Add(userTaskAddRequest);

            if (id == null)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(Get), new { id = id.ToString() }, id);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var userTask = await _userTasksRepository.GetById(id);

            if (userTask == null)
            {
                return NotFound();
            }

            return Ok(UserTaskResponse.From(userTask));
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody]UserTaskUpdateRequest userTaskUpdateRequest)
        {
            var userTask = await _userTaskService.Update(userTaskUpdateRequest);

            if (userTask == null)
            {
                return BadRequest();
            }

            return Ok(UserTaskResponse.From(userTask));
        }
    }
}
