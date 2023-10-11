namespace CalculatorWebApp.Models
{
    public class CalcModel
    {
        public double number1 { get; set; }
        public double number2 { get; set; }
        public double result { get; set; }


        public void Add()
        {
            //足し算
            result = number1 + number2;
            
        }

        public void Subtarct()
        {
            //引き算
            result = number1 - number2;
            
        }
    

        public void Multiply()
        {
            //掛け算
            result = number1 * number2;
            
        }

        public void Divide()
        {
            if(number2 != 0)
            {
                //割り算
                result = number1 / number2;
            }
            else
            {
                result = double.NaN;
            }
            
            
        }



    }
}
