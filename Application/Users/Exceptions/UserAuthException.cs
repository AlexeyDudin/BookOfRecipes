using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users.Exceptions
{
    public class UserAuthException: Exception
    {
        public UserAuthException(string message) : base(message)
        { }
    }
}
