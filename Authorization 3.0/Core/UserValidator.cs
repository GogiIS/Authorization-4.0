using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorization_3._0.Core
{
    internal class UserValidator
    {
        public static bool Validate(string login, string password) =>
            login == "admin" && password == "admin";
    }
}
