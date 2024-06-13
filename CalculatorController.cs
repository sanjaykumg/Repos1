using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebCalculatorProject.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculate(decimal nr1, decimal nr2, string operation)
        {
            string error = string.Empty;
            decimal result = 0;
            if (operation == "+")
            {
                result = Add(nr1, nr2);
            }
            else if (operation == "-")
            {
                result = Subtract(nr1, nr2);
            }
            else if (operation == "*")
            {
                result = Multiply(nr1, nr2);
            }
            else if (operation == "/")
            {
                if (nr2 != 0 )
                {
                    result = Divide(nr1, nr2);
                }
                else
                {
                    error = " ''Can't divide with 0!'' ";
                    return View("Index", $"{error}");
                }
            }
            return View("Index", $"{nr1} {operation} {nr2} = {result}");

        }

        private decimal Divide(decimal nr1, decimal nr2)
        {
            return nr1 / nr2;
        }

        private decimal Multiply(decimal nr1, decimal nr2)
        {
            return nr1 * nr2;
        }

        private decimal Subtract(decimal nr1, decimal nr2)
        {
            return nr1 - nr2; ;
        }

        private decimal Add(decimal nr1, decimal nr2)
        {
            return nr1 + nr2;
        }
    }
}