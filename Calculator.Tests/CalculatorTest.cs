namespace Calculator.Tests
{
    public class CalculatorTest
    {

        [Fact(DisplayName = "Should be able sum two numbers and return")]
        public static void Sum()
        {
            Calculator calculator = new();
            double result = calculator.Sum(1, 2);

            Assert.Equal(3, result);
        }


        [Fact(DisplayName = "Should be able sub two numbers and return")]
        public static void Sub()
        {
            Calculator calculator = new();
            double result = calculator.Sub(1, 2);

            Assert.Equal(-1, result);
        }
    }
}