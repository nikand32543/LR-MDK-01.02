using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnitTestLib;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
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
