

namespace Challenge21Days.Test
{
    class StatisticsTest
    {
        [Test]
        public void CheckCorrectValueForMin()
        {
            //arrange
            var testUser = new Employee("Weronika", "Testarossa");
            testUser.AddGrade(9);
            testUser.AddGrade(8);
            testUser.AddGrade(11);
            //act
            var stats = testUser.GetStatistics();
            //assert
            Assert.AreEqual(8, stats.Min);
        }
        [Test]
        public void CheckCorrectValueForMax()
        {
            //arrange
            var testUser = new Employee("Magdalena", "Testarossa");
            testUser.AddGrade(9);
            testUser.AddGrade(8);
            testUser.AddGrade(11);
            //act
            var stats = testUser.GetStatistics();
            //assert
            Assert.AreEqual(11, stats.Max);
        }
        [Test]
        public void CheckIfValueIsAvarage()
        {
            //arrange
            var testUser = new Employee("Olga", "Testarossa");
            testUser.AddGrade(2);
            testUser.AddGrade(8);
            testUser.AddGrade(5);
            //act
            var stats = testUser.GetStatistics();
            //assert
            Assert.AreEqual(5, stats.Avarage);
        }

    }
}
