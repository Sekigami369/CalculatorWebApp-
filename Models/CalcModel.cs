namespace CalculatorWebApp.Models
{
    public class CalcModel
    {
        public double number1 { get; set; }
        public double number2 { get; set; }

        public double result = 0;
        public double Getresult()
        {
            return result;
        }

        private void Setresult(double result)
        {
            this.result = result;
        }


        public void Add()
        {
            //足し算
            result = number1 + number2;

            Setresult(result);
        }

        public void Subtrarct()
        {
            //引き算
            /*result = number1 - number2;
            return result;            
            */
            result = number1 - number2;

            Setresult(result);
        }
    

        public void Multiply()
        {
            //掛け算
            /*
            result = number1 * number2;
            return result;            
            */
            result = number1 * number2;

            Setresult(result);
        }

        public void Divide()
        {
            if(number2 != 0)
            {
                //割り算
                /*
                result = number1 / number2;
                return result;
                */
                result = number1 / number2;

                Setresult(result);
            }
            else
            {
                /*
                result = double.NaN;
                return result;
                */
                result = double.NaN;

                Setresult(result);
            }
        }
    }
}
