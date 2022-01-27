using TaskAssignment.Common.ErrorMessages.Interface;
using TaskAssignment.Domain.Entities;
using TaskAssignment.Domain.Factories;
using TaskAssignment.Domain.Repositories.Interfaces;
using TaskAssignment.Domain.Requests;
using TaskAssignment.Domain.Services.Interfaces;

namespace TaskAssignment.Domain.Services
{
    public class UserTaskService : IUserTaskService
    {
        private readonly IErrorMessageService _errorMessageService;
        private readonly IUserTasksRepository _userTasksRepository;
        private readonly IUsersRepository _usersRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UserTaskService(IErrorMessageService errorMessageService,
            IUserTasksRepository userTasksRepository,
            IUsersRepository usersRepository,
            IUnitOfWork unitOfWork)
        {
            _errorMessageService = errorMessageService;
            _userTasksRepository = userTasksRepository;
            _usersRepository = usersRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<int?> Add(UserTaskAddRequest userTaskAddRequest)
        {
            await _unitOfWork.BeginTransactionAsync();
            try
            {
                var userTask = UserTaskFactory.FromUserTaskRequest(userTaskAddRequest);
                var user = await _usersRepository.GetById(userTask.UserId);

                if (!IsUserTaskValid(userTask, user))
                {
                    await _unitOfWork.RollbackAsync();
                    return null;
                }
                
                var addedUserTask = await _userTasksRepository.Add(userTask);

                await _unitOfWork.CommitAsync();

                return addedUserTask.Id;
            }
            catch
            {
                _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task<UserTask?> Update(UserTaskUpdateRequest userTaskUpdateRequest)
        {
            await _unitOfWork.BeginTransactionAsync();
            try
            {
                var newUserTask = UserTaskFactory.FromUserTaskRequest(userTaskUpdateRequest);
                var oldUserTask = await _userTasksRepository.GetById(newUserTask.Id);
                var user = await _usersRepository.GetById(newUserTask.UserId);

                if(oldUserTask == null)
                {
                    _unitOfWork.RollbackAsync();
                    _errorMessageService.Add("User task does not exist in the database");
                    return null;
                }

                if (!IsUserTaskValid(newUserTask, user))
                {
                    await _unitOfWork.RollbackAsync();
                    return null;
                }

                var updatedUserTask = await _userTasksRepository.Update(newUserTask);

                await _unitOfWork.CommitAsync();

                return updatedUserTask;
            }
            catch
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        private bool IsUserTaskValid(UserTask userTask, User? user)
        {
            if (!userTask.IsValid())
            {
                _errorMessageService.AddRange(userTask.ErrorMessages);
                return false;
            }

            if (user == null)
            {
                _errorMessageService.Add("User was not found in the database");
                return false;
            }

            if (user?.UserTasks?.Sum(ut => ut.Estimate) + userTask.Estimate > 1)
            {
                _errorMessageService.Add("User can't have more than 1.0 on tasks");
                return false;
            }

            return true;
        }
    }
}
