using NUnit.Framework;

namespace CalculatorTest
{

    public class Sum
    {
        /// <summary>
        /// Addition Test
        /// </summary>
        [Test]
        public void AdditionTest()
        {
            int a = 10;
            int b = 10;

            int sum = a + b;

            Assert.AreEqual(sum, 20);
        }

        /// <summary>
        /// Subtraction Test
        /// </summary>
        [Test]
        public void SubtractionTest()
        {
            int a = 100;
            int b = 50;

            int sum = a - b;

            Assert.AreEqual(sum, 50);
        }
    }
}
