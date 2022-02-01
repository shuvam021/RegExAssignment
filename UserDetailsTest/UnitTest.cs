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
            string[] testCasesUserLastName = { "", "", "", "", "", "" };
            // CheckStatus(testCasesUserLastName, userDetailsNamePattern);
            Assert.IsFalse(_app.CheckStatus("do", pattern));
            Assert.IsFalse(_app.CheckStatus("Do", pattern));
            Assert.IsFalse(_app.CheckStatus("1Do", pattern));
            Assert.IsFalse(_app.CheckStatus("Doe123", pattern));
            // // valid values 
            Assert.IsTrue(_app.CheckStatus("Doey", pattern));
            Assert.IsTrue(_app.CheckStatus("Doe", pattern));
        }
    }
}