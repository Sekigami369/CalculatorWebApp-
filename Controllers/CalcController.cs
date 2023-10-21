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
        [Route("Calculate")]
        public IActionResult Calculate(string operation)
        {
            switch (operation)
            {
                case "Add":
                    calcModel.Add();
                    //calcModel.result = calcModel.Add();                    
                    //calcModel.Getresult();
                    break;

                case "Subtract":
                    calcModel.Subtrarct();
                    //calcModel.Getresult();
                    //calcModel.result = calcModel.Subtarct(); 
                    break;

                case "Multiply":
                    calcModel.Multiply();
                    //calcModel.Getresult();
                    //calcModel.result = calcModel.Multiply();
                    break;

                case "Divide":
                    calcModel.Divide();
                    //calcModel.Getresult();
                    //calcModel.result = calcModel.Divide();
                    break;

                default: 
                    throw new NotImplementedException();                      
            }
            
            return View();
        }
    }
}
