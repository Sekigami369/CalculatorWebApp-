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
                    
                    calcModel.Add();                    
                    
                    break;

                case "Subtract":
                    
                    
                    calcModel.Subtrarct(); 
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
            
            return View("CalcView", calcModel);
        }
    }
}
