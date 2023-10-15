using CalculatorWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace CalculatorWebApp.Controllers
{
    public class CalcController : Controller
    {

        private readonly ILogger<CalcController> logger;

        private CalcModel calcModel;
       
        public CalcController(CalcModel calcModel, ILogger<CalcController> logger)
        {
            this.calcModel = calcModel;
            this.logger = logger;
        }

        public IActionResult CalcView()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(string operation)
        {
            switch (operation)
            {
                case "Add":
                    calcModel.result = calcModel.Add();
                    break;

                case "Subtract":
                    calcModel.result = calcModel.Subtarct(); 
                    break;

                case "Multiply":
                    calcModel.result = calcModel.Multiply();
                    break;

                case "Divide":
                    calcModel.result = calcModel.Divide();
                    break;

                default: 
                    throw new NotImplementedException();                      
            }
            
            return View();
        }
    }
}
