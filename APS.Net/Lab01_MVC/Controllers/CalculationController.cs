using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;



namespace Lab01_MVC.Controllers
{
    public class CalculationController : Controller
    {
        // GET: Calculation
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        public ActionResult Index()
        {
            return View();
        }

        // "+"
        public ActionResult Summary()
        {
            string strNumber1 = Request.QueryString["Number1"];
            string strNumber2 = Request.QueryString["Number2"];

            if (IsNumber(strNumber1) == true && IsNumber(strNumber2) == true)
            {
                int sum = Convert.ToInt32(strNumber1) + Convert.ToInt32(strNumber2);
                return View((object)sum.ToString());
            }
            else
            {
                return View((object)("Invalid ! Your Input must be a number"));
            }
        }

        // "/"
        public ActionResult Division()
        {
            string strNumber1 = Request.QueryString["Number1"];
            string strNumber2 = Request.QueryString["Number2"];
            

            if (IsNumber(strNumber1) == true && IsNumber(strNumber2) == true)
            {
                int div = Convert.ToInt32(strNumber1) / Convert.ToInt32(strNumber2);
                return View((object)div.ToString());
            }
            else
            {
                return View((object)("Invalid ! Your Input must be a number"));
            }


        }

        // "-"
        public ActionResult Subtraction()
        {
            string strNumber1 = Request.QueryString["Number1"];
            string strNumber2 = Request.QueryString["Number2"];

            if (IsNumber(strNumber1) == true && IsNumber(strNumber2) == true)
            {
                int sub = Convert.ToInt32(strNumber1) - Convert.ToInt32(strNumber2);
                return View((object)sub.ToString());
            }
            else
            {
                return View((object)("Invalid ! Your Input must be a number"));
            }
        }

        // "*"
        public ActionResult Muitiplication()
        {
            string strNumber1 = Request.QueryString["Number1"];
            string strNumber2 = Request.QueryString["Number2"];
            

            if (IsNumber(strNumber1) == true && IsNumber(strNumber2) == true)
            {
                int mui = Convert.ToInt32(strNumber1) * Convert.ToInt32(strNumber2);
                return View((object)mui.ToString());
            }
            else
            {
                return View((object)("Invalid ! Your Input must be a number"));
            }
        }

        //Input http://localhost:1457/Calculation/ArrayStats?Arr=[1, 2, 3, 4, 5]
        //Output : Array has 5 elements  and max is 5 and min is 1 

        public ActionResult ArrayStats()
            {
            string Arr = Request.QueryString["Arr"];
            string Check = Request.QueryString["Check"];
         
            int max = 0;
            int min = 90;
            for (int i = 0; i < Arr.Length; i++)
            {

                if (Arr[i] > max && Arr[i] <= 57 && Arr[i] >= 48)
                {
                    max = Arr[i];
                }

                if (Arr[i] < min && Arr[i] <= 57 && Arr[i] >= 48)
                {
                    min = Arr[i];
                }
            }
            
            int a = max - '0';
            int b = min - '0';
            int c = ((Arr.Length - 1) / 2);

            //Check Min
            if(String.Compare(Check, "Min", true) == 0)
            {
                return View((object)("Array Min is " + b));
            }
            //Check Max
            else if(String.Compare(Check, "Max", true) == 0)
            {
                return View((object)("Array Max is " + a));
            }
            //Check Num
            else if (String.Compare(Check, "Num", true) == 0)
            {
                return View((object)("Array has " + c + " elements"));
            }

            return View((object)("Array has elements " + c.ToString() + " and max is " + a.ToString() + " and min is " + b.ToString()));
        }


        public ActionResult Math()
        {

            string strNumber1 = Request.QueryString["Number1"];
            string strNumber2 = Request.QueryString["Number2"];
            string strDo = Request.QueryString["Do"];


            if (String.Compare(strDo, "Addition", true) == 0)
            {
                int add = Convert.ToInt32(strNumber1) + Convert.ToInt32(strNumber2);
                return View((object)add.ToString());
            }

            else if (String.Compare(strDo, "Subtraction", true) == 0)
            {
                int sub = Convert.ToInt32(strNumber1) - Convert.ToInt32(strNumber2);
                return View((object)sub.ToString());
            }

            else if (String.Compare(strDo, "Multiplication", true) == 0)
            {
                int mul = Convert.ToInt32(strNumber1) * Convert.ToInt32(strNumber2);
                return View((object)mul.ToString());
            }

            else if (String.Compare(strDo, "Division", true) == 0)
            {
                int div = Convert.ToInt32(strNumber1) / Convert.ToInt32(strNumber2);
                return View((object)div.ToString());
            }

            return View((object)("Ohh"));
        }

    }
}