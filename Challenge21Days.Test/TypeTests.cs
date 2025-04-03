namespace Challenge21Days.Test
{
    public class TypeTests
    {
        [Test]
        public void CheckIfObjectAreNotEqual()
        {
            //arrange
            var userTest1 = GetEmployee("Zbyszek");
            var userTest2 = GetEmployee("Monika");

            //act

            //assert
            Assert.AreNotEqual(userTest1, userTest2);



        }
        [Test]
        public void CheckIfIntigerAndFloatAreEqual()

        {
            int value1 = 5;
            float value2 = 5.0f;

            Assert.AreEqual(value1, value2);

        }
        [Test]
        public void CheckIfNamesAreTheSame()
        {
            var userTest3 = GetEmployee("Monika");
            var userTest4 = GetEmployee("Monika");

            Assert.AreEqual(userTest4.Name, userTest3.Name);
        }

        public Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}
