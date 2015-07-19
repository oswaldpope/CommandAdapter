using System.Threading.Tasks;

namespace CommandAdapter.Core
{
    public abstract class CommandBus : ICommandBus
    {
        public virtual Task SubmitAsync<TCommand>(TCommand command, IValidationAdapter validation) where TCommand : ICommand
        {
            throw new System.NotImplementedException();
        }

        public virtual void Submit<TCommand>(TCommand command, IValidationAdapter validation) where TCommand : ICommand
        {
            throw new System.NotImplementedException();
        }
    }
}