using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Users
{
    public class UserFunctions
    {
        public static User Clone(User user)
        {
            User returnedUser = new User();
            //магия клонирования свойств с помощью Reflection
            foreach (PropertyInfo pi in user.GetType().GetProperties())
            {
                foreach (PropertyInfo info in returnedUser.GetType().GetProperties())
                {
                    if (pi.Name == info.Name)
                    {
                        info.SetValue(returnedUser, pi.GetValue(user), null);
                    }
                }
            }
            return returnedUser;
        }
    }
}
