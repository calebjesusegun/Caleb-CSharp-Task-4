using System;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;

namespace CalebSquareRoot.Controllers
{

   public class SquareRootController : Controller
   {

      [HttpGet]
      public ActionResult Root()
      {

         return View();
      }

      [HttpPost]
      public ActionResult Root(string firstNumber, string secondNumber)
      {

         int numberOne = int.Parse(firstNumber);
         int numberTwo = int.Parse(secondNumber);
         string numb = firstNumber;

         // int num = -1;

         // var checkingVal = int.TryParse(firstNumber, out num);
         // ViewBag.checkingVal = checkingVal;
         // var checkingVal2 = int.TryParse(secondNumber, out num);
         // ViewBag.checkingVal2 = checkingVal2;

         // var IsconversionOne = firstNumber;
         // ViewBag.IsconversionOne = IsconversionOne;
         // var IsconversionTwo = secondNumber;
         // ViewBag.IsconversionTwo = IsconversionTwo;

         double squareRootFirst = Math.Sqrt(numberOne);
         double squareRootSecond = Math.Sqrt(numberTwo);

         ViewBag.numberOne = numberOne;
         ViewBag.numberTwo = numberTwo;
         ViewBag.squareRootFirst = squareRootFirst;
         ViewBag.squareRootSecond = squareRootSecond;

         return View();
      }

      private object isNumeric(dynamic numberOne, NumberStyles integer)
      {
         throw new NotImplementedException();
      }
   }
}