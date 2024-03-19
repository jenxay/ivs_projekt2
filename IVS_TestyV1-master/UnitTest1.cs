using IVS_TestyV1;

namespace IVSCalc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddMethod()
        {
            // Arrange
            var calculator = new Calculator();
            double num1 = 2;
            double num2 = 3;
            double expectedSum = 5;

            // Act
            double actualSum = calculator.Add(num1, num2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum, "The sum is not correct");
        }

        [TestMethod]
        public void TestSubMethod()
        {
            // Arrange
            var calculator = new Calculator();
            double num1 = 3;
            double num2 = 2;
            double expectedSum = 1;

            // Act
            double actualDiff = calculator.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(expectedSum, actualDiff, "The diff is not correct");
        }

        [TestMethod]
        public void TestMultMethod()
        {
            // Arrange
            var calculator = new Calculator();
            double num1 = 3;
            double num2 = 2;
            double expectedSum = 6;

            // Act
            double actualMult = calculator.Mult(num1, num2);

            // Assert
            Assert.AreEqual(expectedSum, actualMult, "The mult is not correct");
        }

        [TestMethod]
        public void TestDivMethod()
        {
            // Arrange
            var calculator = new Calculator();
            double num1 = 4;
            double num2 = 2;
            double expectedSum = 2;

            // Act
            double actualDiv = calculator.Div(num1, num2);

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

        [TestMethod]
        public void TestFactorial()
        {
            var calculator = new Calculator();
            double num1 = 4;
            double num2 = num1;
            double expectedSum = 24;

            double actualNum = calculator.Fact(num1, num2);

            Assert.AreEqual(expectedSum, actualNum, "Not correct");
        }

        [TestMethod]
        public void TestExponent()
        {
            var calculator = new Calculator();
            double num1 = 5;
            int num2 = 2;
            double expectedSum = 25;

            double actualNum = calculator.Exponent(num1, num2);

            Assert.AreEqual(expectedSum, actualNum, "Not correct");
        }

        [TestMethod]
        public void TestRoot()
        {
            var calculator = new Calculator();
            double num1 = 9;
            int num2 = 2;
            double expectedSum = 3;

            double actualNum = calculator.Root(num1, num2);

            Assert.AreEqual(expectedSum, actualNum, "Not correct");
        }

        [TestMethod]
        public void TestModulo()
        {
            var calculator = new Calculator();
            double num1 = 9;
            double num2 = 2;
            double expectedSum = 1;

            double actualNum = calculator.Modulo(num1, num2);

            Assert.AreEqual(expectedSum, actualNum, "Not correct");
        }

    }
}