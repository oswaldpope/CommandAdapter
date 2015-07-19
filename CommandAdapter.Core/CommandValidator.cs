using System.Threading.Tasks;

namespace CommandAdapter.Core
{
    public abstract class CommandValidator<TCommand> : ICommandValidator<TCommand> where TCommand : ICommand
    {
        public abstract Task Validate(TCommand command, IValidationAdapter validationAdapter);
    }
}