using SimpleProgrammer;
using System.Text.RegularExpressions;

namespace EFYTests
{
    public class UnitTestEFY
    {
        [Fact]
        public void LoginInputTest()
        {
            Users users = new Users();
            users.Login = "AsterDK";
            Regex rg = new Regex("^[A-Z 0-9 a-z].+");
            Assert.Matches(rg, users.Login);
        }
        [Fact]
        public void PhoneIsNotNullTest()
        {
            User_registration en = new User_registration();
            en.Phone = "89678952134";
            Assert.NotNull(en.Phone);
        }
        [Fact]
        public void AdminPasswordLoginTest()
        {
            Administration en = new Administration();
            en.Password = "Admin";
            en.Login = "Admin";
            Assert.Equal(en.Login, en.Password);
        }
        [Fact]
        public void PhoneCheckTest()
        {
            User_registration en = new User_registration();
            en.Phone= "+79503403495";
            Assert.Contains("+79", en.Phone);
        }
        [Fact]
        public void HobbyIsNullTest()
        {
            User_registration en = new User_registration();
            en.Hobby = null;
            Assert.Null(en.Hobby);
        }
        [Fact]
        public void PasswordInputTest()
        {
            Users en = new Users();
            Regex password = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])[0-9 a-z A-Z]{6,}$");
            en.Password = "123Hello";
            Assert.Matches(password, en.Password);
        }
        [Fact]
        public void FIOInputTest()
        {
            User_registration en = new User_registration();
            Regex FIO = new Regex("^[А-Я]{1}[а-я].+ [А-Я]{1}[а-я].+ [А-Я]{1}[а-я].+");
            en.FIO = "Дмитрий";
            Assert.DoesNotMatch(FIO, en.FIO);
        }
    }
}