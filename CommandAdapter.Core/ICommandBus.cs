using System.Threading.Tasks;

namespace CommandAdapter.Core
{
    public interface ICommandBus
    {
        Task SubmitAsync<TCommand>(TCommand command, IValidationAdapter validation) where TCommand : ICommand;

        void Submit<TCommand>(TCommand command, IValidationAdapter validation) where TCommand : ICommand;
    }
}