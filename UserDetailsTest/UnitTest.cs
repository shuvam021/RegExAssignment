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
    }
}