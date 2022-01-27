using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskAssignment.Application.Controllers;
using TaskAssignment.Data.Configuration;
using TaskAssignment.Domain.Repositories.Interfaces;
using TaskAssignment.Domain.Requests;
using TaskAssignment.Domain.Services.Interfaces;

namespace TaskAssignment.Specs.StepDefinitions
{
    [Binding]
    public sealed class UserTasksStepDefinition
    {
        private static UserTaskAddRequest _userTask = new UserTaskAddRequest();
        private readonly IUserTaskService _userTaskService;
        private readonly IUserTasksRepository _userTasksRepository;
        private static IActionResult? _result;
        private readonly AppDbContext _appDbContext;

        public UserTasksStepDefinition(IUserTaskService userTaskService,
            IUserTasksRepository userTasksRepository,
            AppDbContext appDbContext)
        {
            _userTaskService = userTaskService;
            _userTasksRepository = userTasksRepository;
            _appDbContext = appDbContext;
        }

        [BeforeScenario]
        public void Setup()
        {
            _userTask = new UserTaskAddRequest();
            _appDbContext.Database.EnsureDeleted();
            _appDbContext.Database.Migrate();
        }

        [Given("que o título da tarefa é '(.*)'")]
        public void UserTaskTitleIs(string title)
        {
            _userTask = _userTask with { Title = title };
        }

        [Given("a descrição da tarefa é '(.*)'")]
        public void UserTaskDescriptionIs(string description)
        {
            _userTask = _userTask with { Description = description };
        }

        [Given("a estimativa da tarefa é (.*)")]
        public void UserTaskEstimateIs(decimal estimate)
        {
            _userTask = _userTask with { Estimate = estimate };
        }

        [Given("o usuário da tarefa é o usuário teste")]
        public void UserTaskUserIsTestUser()
        {
            _userTask = _userTask with { UserId = 1 };
        }

        [When("adicionar uma tarefa")]
        public void AddTask()
        {
            var userTaskController = new UserTaskController(_userTaskService, _userTasksRepository);
            _result = userTaskController.Add(_userTask).Result;
        }

        [Then("deve ocorrer um erro")]
        public void ShouldReturnError()
        {
            _result.Should().NotBeNull();
            if(_result != null)
            {
                var badRequestResult = (BadRequestResult)_result;
                badRequestResult.StatusCode.Should().Be(StatusCodes.Status400BadRequest);
            }
        }
    }
}
