namespace CalculatorWebApp.Models
{
    public class CalcModel
    {
        public double number1 { get; set; }
        public double number2 { get; set; }
        public double result { get; set; }

        double calcAns = 0;

        public double Add()
        {
            //足し算
            result = number1 + number2;
            
            return result;
        }

        public double Subtarct()
        {
            //引き算
            result = number1 - number2;
            return result;            
        }
    

        public double Multiply()
        {
            //掛け算
            result = number1 * number2;
            return result;            
        }

        public double Divide()
        {
            if(number2 != 0)
            {
                //割り算
                result = number1 / number2;
                return result;
            }
            else
            {
                result = double.NaN;
                return result;
            }
        }
    }
}
