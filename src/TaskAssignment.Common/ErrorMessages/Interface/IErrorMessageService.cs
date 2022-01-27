namespace TaskAssignment.Common.ErrorMessages.Interface
{
    public interface IErrorMessageService
    {
        bool HasErrorMessages();

        void Add(string message);

        void AddRange(IEnumerable<string> messages);

        IEnumerable<string> GetAll();
    }
}
