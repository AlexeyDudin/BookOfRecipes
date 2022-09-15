namespace Application.Users.Exceptions
{
    public class UserAuthException: Exception
    {
        public UserAuthException(string message) : base(message)
        { }
    }
}
