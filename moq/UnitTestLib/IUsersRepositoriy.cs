using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestLib
{
    public interface IUsersRepositoriy
    {
        List<User> LoadUserInfo();
        User GetUser(string login);
        void Add(User user);


    }
}
