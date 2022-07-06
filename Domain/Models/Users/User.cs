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
        public string Description { get; set; }
    }
}