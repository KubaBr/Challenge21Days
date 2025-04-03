using System.Security.Cryptography.X509Certificates;

namespace Challenge21Days.Test
{
    public class Tests
    {
        [Test]
        public void CheckIfResultAddedCorrectly()
        {
            //arrange
            var testUser = new Employee("Robert", "Testowy", 35);
            testUser.AddGrade(10);
            testUser.AddGrade(7);

            //act
            var result = testUser.Result;
            //assert
            Assert.AreEqual(17, result);

        }
        [Test]
        public void CheckIfContructorWorksFine()
        {
            //arrange
            string testName = "Edward";
            string testLastName = "Tester";
            int testAge = 77;
            //act
            var testUser1 = new Employee("Edward", "Tester", 77);
            //assert

            Assert.AreEqual(testName, testUser1.Name);
            Assert.AreEqual(testLastName, testUser1.LastName);
            Assert.AreEqual(testAge, testUser1.Age);
            Assert.AreEqual(0, testUser1.Result);

        }
        [Test]
        public void CheckIfResultCanBeNegative()
        {
            //arrange
            var testUser = new Employee("Kasia", "Test�wna", 22);
            testUser.AddGrade(10);
            testUser.AddGrade(7);
            testUser.AddGrade(-7);
            testUser.AddGrade(-6);
            testUser.AddGrade(-6);


            //act
            var result = testUser.Result;
            //assert
            Assert.AreEqual(-2, result);
        }
    }
}