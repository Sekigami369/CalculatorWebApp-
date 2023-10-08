namespace CalculatorWebApp.Models
{
    public class CalcModel
    {
        public double Add(double a, double b)
        {
            //足し算
            return a + b;
            
        }

        public double Subtarct(double a, double b)
        {
            //引き算
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            //掛け算
            return a * b;
        }

        public double Divide(double a, double b)
        {
            //割り算
            return a / b;
        }



    }
}
