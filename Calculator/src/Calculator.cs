
namespace Calculator
{
    public class Calculator : CalculatorContract
    {
        public override double Sub(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public override double Sum(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

    }
}