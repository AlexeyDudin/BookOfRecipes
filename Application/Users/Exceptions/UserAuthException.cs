namespace Application.Users.Exceptions
{
    public class UserAuthException: Exception
    {
        private readonly string _login;
        private readonly string _password;
        public UserAuthException(string login, string password)
        {
            _login = login;
            _password = password;
        }

        public override string Message => $"Не найден пользователь с таким логином {_login} и паролем {_password}";
    }
}
