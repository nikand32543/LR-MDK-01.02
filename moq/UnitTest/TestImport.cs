using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using UnitTestLib;
namespace UnitTest
{
    [TestClass]
    public class TestImport
    {
        [TestMethod]
        public void TestMethod_SuccessfulImport() // если файл вернул одного валидного пользователя  и в БД его нет то ImportUser вернёт true
        {
            List<User> users = new List<User>
            {
                new User { Login = "login123", Password = "123", Name = "Ivan", LastName = "Ivanov" }
            };

            var fileMock = new Mock<IUserFile>(); // мок обьект для интерфейса
            fileMock.Setup(files => files.ReadAllLines("users.txt")).Returns(users);
            var repoMock = new Mock<IUsersRepositoriy>();
            repoMock.Setup(repo => repo.GetUser("login123")).Returns((User)null);
            IUserFile file = fileMock.Object; // получение заглушки moq
            IUsersRepositoriy repository = repoMock.Object;
            ImportFromFile importer = new ImportFromFile(file, repository);
            bool Flag = importer.ImportUser("users.txt");
            Assert.IsTrue(Flag);
        }
        [TestMethod]
        public void TestMethod_UnsuccessfulImport() // неудачный импорт пользователь с пробелом  пропущен, в БД ничего
        {
            List<User> users = new List<User>
            {
                new User { Login = "i van", Password = "123", Name = "Ivan", LastName = "Ivanov" }
            };
            Mock<IUserFile> fileMock = new Mock<IUserFile>();
            fileMock.Setup(files => files.ReadAllLines("users.txt")).Returns(users);
            Mock<IUsersRepositoriy> repoMock = new Mock<IUsersRepositoriy>();
            repoMock.Setup(repo => repo.GetUser(It.IsAny<string>())).Returns((User)null);
            IUserFile file = fileMock.Object;
            IUsersRepositoriy repository = repoMock.Object;
            ImportFromFile importer = new ImportFromFile(file, repository);
            bool Flag = importer.ImportUser("users.txt");
            Assert.IsTrue(Flag);
            repoMock.Verify(repo => repo.Add(It.IsAny<User>()), Times.Never); // ничего не добавлено
        }
    }
}
