using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestLib
{
    public class UserServicec
    {
        IUsersRepositoriy repository_;
        public UserServicec(IUsersRepositoriy repository)
        {
            repository_ = repository;
        }
        public bool Autorization(string login, string password)
        {
            User user = repository_.GetUser(login);
            if ( user.Password == password && user.Login == login)
            {
                return true;
            }
            return false;
        }
        public bool Registration(string login, string password)
        {
            User user = repository_.GetUser(login);
            if(user != null)
            {
                return false;
            }
            User newUser = new User
            {
                Login = login,
                Password = password
            };
            repository_.Add(newUser);
            return true;
        }
    }
}
