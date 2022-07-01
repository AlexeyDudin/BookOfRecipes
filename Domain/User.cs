namespace Domain
{
    public class User
    {
        private int id;
        private string _userName;
        private string _login;
        private string _password;
        private string _about;

        public int Id { get => id; set => id = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string Login { get => _login; set => _login = value; }
        public string Password { get => _password; set => _password = value; }
        public string About { get => _about; set => _about = value; }

        public User(string userName, string password)
        {
            _userName = userName ?? throw new ArgumentNullException("Username is null");
            _password = password ?? throw new ArgumentNullException("Password is null");
        }
    }
}