using System.Security.Cryptography.X509Certificates;

namespace Challenge21Days.Test
{
    public class EmployeeTests
    {
        [Test]
        public void CheckIfResultAddedCorrectly()
        {
            //arrange
            var testUser = new Employee("Robert", "Testowy");
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
            var testUser1 = new Employee("Edward", "Tester");
            //assert

            Assert.AreEqual(testName, testUser1.Name);
            Assert.AreEqual(testLastName, testUser1.LastName);
            Assert.AreEqual(0, testUser1.Result);

        }
        [Test]
        public void CheckIfLetterGradesWorksProperly()
        {
            Employee testUser = new Employee("Mieczys³aw", "Mieczys³awski");
            testUser.AddGrade('A');
            testUser.AddGrade('c');
            var statistics = testUser.GetStatistics();

            var result = statistics.Avarage;

            Assert.AreEqual(80, result);

        }

        [Test]
        public void CheckIfSumOfGradesReturnsCorrectLetter()
        {
            Employee testUser = new Employee("Bogumi³a", "Bogumilska");
            testUser.AddGrade(55);
            testUser.AddGrade(100);
            testUser.AddGrade(1);
            var statistics = testUser.GetStatistics();

            var result = statistics.AvarageLetter;

            Assert.AreEqual('C', result);
        }

    }
}