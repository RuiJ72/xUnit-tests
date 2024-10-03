using ProjetoDeTeste;
using Xunit;

namespace TesteCalculadora
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1.0, 2.0, 3.0)]
        [InlineData(4.0, 5.0, 9.0)]
        public void TestSum(double value1, double value2, double result)
        {
            Calculator calculator = new Calculator();
            double resultCalculator = calculator.Sum(value1, value2);
            Assert.Equal(result, resultCalculator);
        }

        [Theory]
        [InlineData(1.0, 2.0, 2.0)]
        [InlineData(4.0, 5.0, 20.0)]
        public void TestMultiplication(double value1, double value2, double result)
        {
            Calculator calculator = new Calculator();
            double resultCalculator = calculator.Multiplication(value1, value2);
            Assert.Equal(result, resultCalculator);
        }

        [Theory]
        [InlineData(6.0, 2.0, 4.0)]
        [InlineData(5.0, 5.0, 0.0)]
        public void TestSubtraction(double value1, double value2, double result)
        {
            Calculator calculator = new Calculator();
            double resultCalculator = calculator.Subtraction(value1, value2);
            Assert.Equal(result, resultCalculator);
        }

        [Theory]
        [InlineData(6.0, 2.0, 3.0)]
        [InlineData(5.0, 5.0, 1.0)]
        public void TestDivision(double value1, double value2, double result)
        {
            Calculator calculator = new Calculator();
            double resultCalculator = calculator.Division(value1, value2);
            Assert.Equal(result, resultCalculator);
        }

        [Fact]
        public void TestDivisionByZero()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(3.0, 0.0));
        }

        [Fact]
        public void TestBackground()
        {
            Calculator calculator = new Calculator();
            calculator.Sum(1.0, 2.0);
            calculator.Sum(2.0, 8.0);
            calculator.Sum(3.0, 7.0);
            calculator.Sum(4.0, 1.0);

            var list = calculator.Background();
            Assert.NotEmpty(list);
            Assert.Equal(3, list.Count);
        }
    }
}
