namespace Calculator
{
    public static class Program
    {
        private static double Sum(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }

        private static double SumByRef(ref double firstValue, ref double secondValue)
        {
            return firstValue + secondValue;
        }
        public static void Main()
        {
        }
    }
}