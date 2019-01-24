namespace SnackBar.Shared.BaseHandler
{
    public interface IHandler<T> where T : class
    {
        void Handle(T command);
    }
}
