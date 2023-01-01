namespace Application.CommandPattern
{
    public interface ICommandBus
    {
        Task Dispatch<T>(T command) where T : ICommand;
    }
}
