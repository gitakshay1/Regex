
using Regex_Programs;

namespace RegexTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstNameTest()
        {
            Regex1 regex1 = new Regex1();
            

            bool ActualOutPut = regex1.FirstName("Akshay");

            Assert.AreEqual(true, ActualOutPut);
        }
        [TestMethod]
        public void LastNameTest()
        {
            Regex1 regex1 = new Regex1();


            bool ActualOutPut = regex1.LastName("Patil");

            Assert.AreEqual(true, ActualOutPut);
        }
        [TestMethod]
        public void EmailIdTest()
        {
            Regex1 regex1 = new Regex1();


            bool ActualOutPut = regex1.EmailId("aksjbucs@gmail.com");

            Assert.AreEqual(true, ActualOutPut);
        }
        public void PhoneNumberTest()
        {
            Regex1 regex1 = new Regex1();


            bool ActualOutPut = regex1.PhoneNumber("9862713396");

            Assert.AreEqual(true, ActualOutPut);
        }
        public void PasswordTest()
        {
            Regex1 regex1 = new Regex1();


            bool ActualOutPut = regex1.Password("aabb@s9sA");

            Assert.AreEqual(true, ActualOutPut);
        }

    }
}