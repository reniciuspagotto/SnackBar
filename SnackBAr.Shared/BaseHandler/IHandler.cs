namespace SnackBar.Shared.BaseHandler
{
    public interface IHandler<T> where T : class
    {
        object Handle(T command);
    }
}
