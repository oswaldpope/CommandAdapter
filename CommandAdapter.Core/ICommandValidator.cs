using System.Threading.Tasks;

namespace CommandAdapter.Core
{
    public interface ICommandValidator<TCommand> where TCommand : ICommand
    {
        Task Validate(TCommand command, IValidationAdapter validationAdapter);
    }
}