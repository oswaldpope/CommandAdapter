using System.Threading.Tasks;

namespace CommandAdapter.Core
{
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        Task Execute(TCommand command, IValidationAdapter validationAdapter);
    }
}