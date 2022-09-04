namespace Application.Users.Exceptions
{
    public class UserCreateException : Exception
    {
        public UserCreateException(string message) : base(message)
        { }
    }
}
