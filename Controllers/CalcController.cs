using CalculatorWebApp.Models;
using CalculatorWebApp.Views.Calc;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace CalculatorWebApp.Controllers
{
    public class CalcController : Controller
    {
        private CalcModel calcModel;
        private CalcView calcView;

        public CalcController(CalcModel calcModel, CalcView calcView)
        {
            this.calcModel = calcModel;
            this.calcView = calcView;
        }

        public void PerformCalc(double a, double b, string operation)
        {
            double results = 0;

            switch (operation)
            {
                case "Add":
                    results = a + b;
                    break;
                case "Subtract":
                    results = a - b;
                    break;
                case "Multiply":
                    results = a * b;
                    break;
                case "Divide":
                    results = a / b;
                    break;
                default:
                    throw new NotImplementedException();
                    
            }
            //calcView.DisplayResult(results);
        }
    }
}
