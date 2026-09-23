using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using UnitTestLib;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod2() // если файл вернул одного валидного пользователя  и в БД его нет то ImportUser вернёт true
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

        [TestMethod]
        public void TestMethod1()
        {
            var mock = new Mock<IUsersRepositoriy>();
            mock.Setup(repo => repo.GetUser("login123"))
                .Returns(new User { Login = "login123", Password = "123" });
            IUsersRepositoriy repository = mock.Object;
            UserServicec userServicec = new UserServicec(repository);
            bool Flag = userServicec.Autorization("login123", "123");
            Assert.IsTrue(Flag);
        }
        [TestMethod]
        public void TestMethod_failed()
        {
            var mock = new Mock<IUsersRepositoriy>();
            mock.Setup(repo => repo.GetUser("login124"))
                .Returns(new User { Login = "login124", Password = "correct_password" });
            IUsersRepositoriy repository = mock.Object;
            UserServicec userServicec = new UserServicec(repository);
            bool Flag = userServicec.Autorization("login124", "wrong_password");
            Assert.IsFalse(Flag);
        }
        [TestMethod]
        public void TestMethod_registr()
        {
            var mock = new Mock<IUsersRepositoriy>();
            mock.Setup(repo => repo.GetUser("new_user"))
                .Returns((User)null);
            IUsersRepositoriy repository = mock.Object;
            UserServicec userServicec = new UserServicec(repository);
            bool Flag = userServicec.Registration("new_user", "password123");
            Assert.IsTrue(Flag);
        }
    }
}
