// See https://aka.ms/new-console-template for more information
using Domain.Models.Users;
using Infrastructure;

UserContext userContext = new UserContext();
User newUser = new User("admin", "admin");

userContext.Users.Add(newUser);
userContext.SaveChanges();

foreach (User user in userContext.Users)
{
    Console.WriteLine(user.UserName);
}