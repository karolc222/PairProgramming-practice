using PairProgrammingPractice;

namespace TestSuite
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Arrange
            int[] testInput = { 1 };

            //Act
            int result = Calculator.SumMiddleNumbers(testInput);

            // Assert
            Assert.That(result.Equals(1));

        }
    }
}