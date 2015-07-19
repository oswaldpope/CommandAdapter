namespace CommandAdapter.Core
{
    public interface IValidationAdapter
    {
        bool IsValid { get; }

        void AddError(string key, string errorMessage);
    }
}