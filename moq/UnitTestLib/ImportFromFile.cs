using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestLib
{
    public class ImportFromFile
    {
        IUserFile UserFile_;
        IUsersRepositoriy repository_;
        public ImportFromFile(IUserFile file)
        {
            UserFile_ = file;

        }
        public bool ImportUser (string filePath)
        {
            List<User> users = UserFile_.ReadAllLines(filePath);
            List<User> result = new List<User>();
            foreach (User user in users)
            {
                if (user.Login.Contains (" ") ||
                    user.Password.Contains(" ") ||
                    user.Name.Contains(" ") || 
                    user.LastName.Contains(" "))
                {
                    continue;
                }
                result.Add(user);
                
            }
            return true;
        }
    }
}
