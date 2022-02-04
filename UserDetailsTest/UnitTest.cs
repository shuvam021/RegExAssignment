using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegExAssignment;

namespace UserDetailsTest
{
    [TestClass]
    public class UnitTest
    {
        private UserDetails _app;

        [TestInitialize]
        public void Setup()
        {
            _app = new UserDetails();
        }
        
        [TestMethod]
        public void TestUserFirstName()
        {
            string pattern = _app._namePattern;
            // invalid values 
            Assert.IsFalse(_app.CheckStatus("john", pattern));
            Assert.IsFalse(_app.CheckStatus("jon", pattern));
            Assert.IsFalse(_app.CheckStatus("1johns", pattern));
            Assert.IsFalse(_app.CheckStatus("Jon1", pattern));
            Assert.IsFalse(_app.CheckStatus("Jon 12", pattern));
            Assert.IsFalse(_app.CheckStatus("Joh n", pattern));
            // valid values 
            Assert.IsTrue(_app.CheckStatus("John", pattern));
            Assert.IsTrue(_app.CheckStatus("Jon", pattern));
        }
        
        [TestMethod]
        public void TestUserLastName()
        {
            string pattern = _app._namePattern;
            // invalid values 
            Assert.IsFalse(_app.CheckStatus("do", pattern));
            Assert.IsFalse(_app.CheckStatus("Do", pattern));
            Assert.IsFalse(_app.CheckStatus("1Do", pattern));
            Assert.IsFalse(_app.CheckStatus("Doe123", pattern));
            // // valid values 
            Assert.IsTrue(_app.CheckStatus("Doey", pattern));
            Assert.IsTrue(_app.CheckStatus("Doe", pattern));
        }
        
        [TestMethod]
        public void TestUserEmail()
        {
            string pattern = _app._emailPattern;
            string[] invalidEmails =
            {
                "abc",
                "abc@bl.co.",
                "abc123$bl.cocom",
                "abc123@bl.co.com",
                "abc123@.bl.co.in",
                ".abc@abc.bl.co.in",
                "abc()*@bl.co.in",
                "abc@%*.bl.co.in",
                "abc123@.com",
                "abc123@.com.com",
                ".abc@abc.com",
                "abc()*@gmail.com",
                "abc@%*.com",
                "abc123$bl.co.com",
            };
            string[] validEmails =
            {
                "abczxss@bl.co.in",
                "abc@bl.co.in",
                "abc@bl.co.com",
                "abc+xyz@bl.co.com",
                "abc.xyz@bl.co.com",
                "abc_xyz@bl.co.com",
                "abc-xyz@bl.co.com",
                "abc-xyz.mkl@bl.co.com",
                "abc-xyz.mk_xyz@bl.co.com",
                "abc-xyz.mk_xyz+hh@bl.co.com",
            };
            foreach (var item in validEmails)
                Assert.IsTrue(_app.CheckStatus(item, pattern));
            foreach (var item in invalidEmails)
                Assert.IsFalse(_app.CheckStatus(item, pattern));
        }
        [TestMethod]
        public void TestUserPhone()
        {
            string pattern = _app._phonePattern;
            string[] invalidPhone =
            {
                "0231",
                "1234567890",
                "91 12345678",
                "9 1234567890",
                "1 1234567890",
                "1 123456abcd",
                "91 123456abcd",
            };
            string[] validPhone =
            {
                "911234567890",
                "91 1234567890",
            };
            foreach (var item in invalidPhone)
                Assert.IsFalse(_app.CheckStatus(item, pattern));
            
            foreach (var item in validPhone)
                Assert.IsTrue(_app.CheckStatus(item, pattern));
        }
        [TestMethod]
        public void TestUserPassword()
        {
            string pattern = _app._passwordPattern;
            string[] invalidPassword =
            {
                "passwd",
                "password",
                "pass1234",
                "12345678",
                "passWord",
                "Password",
            };
            string[] validPassword =
            {
                "Password121",
                "Passwd123",
            };
             foreach (var item in invalidPassword)
                Assert.IsFalse(_app.CheckStatus(item, pattern));
            
            foreach (var item in validPassword)
                Assert.IsTrue(_app.CheckStatus(item, pattern));
        }
    }
}