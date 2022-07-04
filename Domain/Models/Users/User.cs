using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Users
{
    public class User
    {

        [Key]
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string About { get; set; }

        public User(string userName, string password)
        {
            UserName = userName ?? throw new ArgumentNullException("Username is null");
            Password = password ?? throw new ArgumentNullException("Password is null");
        }
    }
}