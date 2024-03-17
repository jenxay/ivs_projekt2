namespace IVS_TestyV1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddMethod()
        {
            // Arrange
            var calculator = new Calculator();
            int num1 = 2;
            int num2 = 3;
            int expectedSum = 5;

            // Act
            int actualSum = calculator.Add(num1, num2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum, "The sum is not correct");
        }

        [TestMethod]
        public void TestSubMethod()
        {
            // Arrange
            var calculator = new Calculator();
            int num1 = 3;
            int num2 = 2;
            int expectedSum = 1;

            // Act
            int actualDiff = calculator.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(expectedSum, actualDiff, "The diff is not correct");
        }

        [TestMethod]
        public void TestMultMethod()
        {
            // Arrange
            var calculator = new Calculator();
            int num1 = 3;
            int num2 = 2;
            int expectedSum = 6;

            // Act
            int actualMult = calculator.Mult(num1, num2);

            // Assert
            Assert.AreEqual(expectedSum, actualMult, "The mult is not correct");
        }

        [TestMethod]
        public void TestDivMethod()
        {
            // Arrange
            var calculator = new Calculator();
            int num1 = 4;
            int num2 = 2;
            int expectedSum = 2;

            // Act
            int actualDiv = calculator.Div(num1, num2);

            // Assert
            Assert.AreEqual(expectedSum, actualDiv, "The div is not correct");
        }

        [TestMethod]
        public void TestMultipleFunc()
        {
            var calculator = new Calculator();
            double num1 = 3;
            double num2 = 2;
            double num3 = 4;
            double num4 = 5;
            double num5 = 6;
            double expectedSum = 1.666666666;

            double actualNum = calculator.MultSum(num1, num2, num3, num4, num5);

            Assert.AreEqual(expectedSum, actualNum, 0.0001, "Not correct");
        }

    }
}