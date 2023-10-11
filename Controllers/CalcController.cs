using CalculatorWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace CalculatorWebApp.Controllers
{
    public class CalcController : Controller
    {
        private CalcModel calcModel;
              

        public CalcController(CalcModel calcModel)
        {
            this.calcModel = calcModel;
          
        }

        public IActionResult CalcView()
        {
            return View("CalcView");
        }

        public IActionResult Calculate(CalcModel calcModel, string operation)
        {
            switch (operation)
            {
                case "Add":
                    calcModel.Add();
                    break;

                case "Subtract":
                    calcModel.Subtarct(); 
                    break;

                case "Multiply":
                    calcModel.Multiply();
                    break;

                case "Divide":
                    calcModel.Divide();
                    break;

                default: 
                    throw new NotImplementedException();                      
            }
            return View("CalcView");
        }
    }
}
