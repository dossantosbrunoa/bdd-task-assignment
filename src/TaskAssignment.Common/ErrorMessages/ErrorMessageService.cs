using TaskAssignment.Common.ErrorMessages.Interface;

namespace TaskAssignment.Common.ErrorMessages
{
    public class ErrorMessageService : IErrorMessageService
    {
        private readonly List<string> _errorMessages;

        public ErrorMessageService()
        {
            _errorMessages = new List<string>();
        }

        public bool HasErrorMessages()
        {
            return _errorMessages.Any();
        }

        public void Add(string message)
        {
            _errorMessages.Add(message);
        }

        public void AddRange(IEnumerable<string> messages)
        {
            _errorMessages.AddRange(messages);
        }

        public IEnumerable<string> GetAll()
        {
            return _errorMessages;
        }
    }
}
