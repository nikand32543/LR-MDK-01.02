using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestLib
{
    public interface IUserFile
    {
        List<User> ReadAllLines(string filePath); // возращает список пользователей
    }
}
